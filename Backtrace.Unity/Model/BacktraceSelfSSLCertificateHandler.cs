using System;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace Backtrace.Unity.Model
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public class BacktraceSelfSSLCertificateHandler : CertificateHandler
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x000028C4 File Offset: 0x00000AC4
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "5")]
		protected override bool ValidateCertificate(byte[] certificateData)
		{
			return default(bool);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x74F4D0", Offset = "0x74DAD0", VA = "0x18074F4D0")]
		public BacktraceSelfSSLCertificateHandler()
		{
		}

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string PUB_KEY;
	}
}
