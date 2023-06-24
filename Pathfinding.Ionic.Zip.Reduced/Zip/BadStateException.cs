using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00007")]
	public class BadStateException : ZipException
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2851AD0", Offset = "0x28500D0", VA = "0x182851AD0")]
		public BadStateException()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2851B20", Offset = "0x2850120", VA = "0x182851B20")]
		public BadStateException(string message)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2851B80", Offset = "0x2850180", VA = "0x182851B80")]
		public BadStateException(string message, Exception innerException)
		{
		}
	}
}
