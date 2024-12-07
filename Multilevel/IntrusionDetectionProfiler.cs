using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel
{
    internal class IntrusionDetectionProfiler
    {
        private static Random random = new Random();

        public static string GenerateRandomIDSLog()
        {
            string timestamp = GenerateRandomTimestamp();
            string sourceIP = GenerateRandomIP();
            string destinationIP = GenerateRandomIP();
            int sourcePort = random.Next(1024, 65535);  // Use ports 1024 to 65535
            int destinationPort = random.Next(80, 443); // Common HTTP/HTTPS ports
            string attackType = GenerateRandomAttackType();
            string severity = GenerateRandomSeverity();
            string logMessage = GenerateRandomMessage(attackType, sourceIP, destinationIP);

            return $"{timestamp} {sourceIP}:{sourcePort} -> {destinationIP}:{destinationPort} | Attack Type: {attackType} | Severity: {severity} | Message: {logMessage}";
        }
        static string GenerateRandomTimestamp()
        {
            DateTime startDate = new DateTime(2020, 1, 1);
            DateTime endDate = DateTime.Now;
            TimeSpan timeSpan = endDate - startDate;
            DateTime randomDate = startDate.AddMilliseconds(random.NextDouble() * timeSpan.TotalMilliseconds);
            return randomDate.ToString("yyyy-MM-dd HH:mm:ss");
        }

        static string GenerateRandomIP()
        {
            return $"{random.Next(1, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}";
        }

        static string GenerateRandomAttackType()
        {
            var attackTypes = new List<string>
            {
                "Port Scanning",
                "SQL Injection",
                "DoS Attack",
                "Malware Activity",
                "Privilege Escalation",
                "Cross-site Scripting (XSS)",
                "Brute Force Login",
                "Buffer Overflow",
                "Unauthorized Access"
            };
            return attackTypes[random.Next(attackTypes.Count)];
        }

        static string GenerateRandomSeverity()
        {
            var severities = new List<string> { "Low", "Medium", "High" };
            return severities[random.Next(severities.Count)];
        }

        static string GenerateRandomMessage(string attackType, string sourceIP, string destinationIP)
        {
            switch (attackType)
            {
                case "Port Scanning":
                    return $"Suspicious port scanning detected from {sourceIP} to {destinationIP}.";
                case "SQL Injection":
                    return $"SQL injection attempt detected from {sourceIP} targeting {destinationIP}.";
                case "DoS Attack":
                    return $"Denial of Service (DoS) attack detected from {sourceIP} to {destinationIP}.";
                case "Malware Activity":
                    return $"Malware activity detected from {sourceIP} to {destinationIP}. Possible infection attempt.";
                case "Privilege Escalation":
                    return $"Privilege escalation detected from {sourceIP} to {destinationIP}. Unauthorized attempt to gain access.";
                case "Cross-site Scripting (XSS)":
                    return $"Cross-Site Scripting (XSS) attack detected from {sourceIP} to {destinationIP}.";
                case "Brute Force Login":
                    return $"Brute force login attempt detected from {sourceIP} targeting {destinationIP}.";
                case "Buffer Overflow":
                    return $"Buffer overflow attempt detected from {sourceIP} to {destinationIP}. Potential exploit attempt.";
                case "Unauthorized Access":
                    return $"Unauthorized access attempt detected from {sourceIP} to {destinationIP}.";
                default:
                    return "Unknown attack detected.";
            }
        }
    }
}
