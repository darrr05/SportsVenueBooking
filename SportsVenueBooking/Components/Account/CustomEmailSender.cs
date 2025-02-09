using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SportsVenueBooking.Data;
using SportsVenueBooking.Domain;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SportsVenueBooking.Components.Account
{
	public class RealEmailSender : IEmailSender<SportsVenueBookingUser>
	{
		private readonly IConfiguration _configuration;

		// Constructor to get the SMTP settings from configuration
		public RealEmailSender(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		private SmtpClient GetSmtpClient()
		{
			var smtpSettings = _configuration.GetSection("EmailSettings");
			var smtpClient = new SmtpClient(smtpSettings["SmtpServer"])
			{
				Port = int.Parse(smtpSettings["SmtpPort"]),
				Credentials = new NetworkCredential(smtpSettings["SmtpUsername"], smtpSettings["SmtpPassword"]),
				EnableSsl = true // Ensure SSL/TLS is enabled
			};
			return smtpClient;
		}

		public async Task SendConfirmationLinkAsync(SportsVenueBookingUser user, string email, string confirmationLink)
		{
			try
			{
				var smtpClient = GetSmtpClient();
				var mailMessage = new MailMessage
				{
					From = new MailAddress("no-reply@example.com"),  // Sender email
					Subject = "Confirm your email",
					Body = $"Please confirm your account by <a href='{confirmationLink}'>clicking here</a>.",
					IsBodyHtml = true  // HTML body
				};
				mailMessage.To.Add(email); // Recipient's email

				await smtpClient.SendMailAsync(mailMessage);  // Send the email
			}
			catch (SmtpException ex)
			{
				// Log error or handle the exception as needed
				throw;  // Optionally, rethrow to handle it at a higher level
			}
		}


		public async Task SendPasswordResetLinkAsync(SportsVenueBookingUser user, string email, string resetLink)
		{
			var smtpClient = GetSmtpClient();
			var mailMessage = new MailMessage
			{
				From = new MailAddress("no-reply@example.com"),
				Subject = "Reset your password",
				Body = $"Please reset your password by <a href='{resetLink}'>clicking here</a>.",
				IsBodyHtml = true
			};
			mailMessage.To.Add(email);

			await smtpClient.SendMailAsync(mailMessage);
		}

		public async Task SendPasswordResetCodeAsync(SportsVenueBookingUser user, string email, string resetCode)
		{
			var smtpClient = GetSmtpClient();
			var mailMessage = new MailMessage
			{
				From = new MailAddress("no-reply@example.com"),
				Subject = "Reset your password",
				Body = $"Please reset your password using the following code: {resetCode}",
				IsBodyHtml = false // Plain text email body
			};
			mailMessage.To.Add(email);

			await smtpClient.SendMailAsync(mailMessage);
		}
	}
}
