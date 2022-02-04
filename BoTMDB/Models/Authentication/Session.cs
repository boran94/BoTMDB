using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Authentication
{
    /// <summary>
    /// Oturum bilgilerinin tutuldugu sinif
    /// </summary>
    public class Session
    {
        /// <summary>
        /// Oturum acildiysa true, aksi halde false degeri alir.
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Oturum Id degeri
        /// </summary>
        [JsonPropertyName("session_id")]
        public string SessionId { get; set; } = "";

        /// <summary>
        /// Oturum bitis tarihi
        /// </summary>
        [JsonPropertyName("expires_at")]
        public string ExpiresAt { get; set; } = "";

        /// <summary>
        /// Misafir Oturum Id degeri
        /// </summary>
        [JsonPropertyName("guest_session_id")]
        public string GuestSessionId { private get { return string.Empty; } init { SessionId = value; } }

    }
}
