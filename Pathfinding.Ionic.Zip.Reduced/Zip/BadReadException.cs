using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000A")]
	public class BadReadException : ZipException
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2851AD0", Offset = "0x28500D0", VA = "0x182851AD0")]
		public BadReadException()
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2851B20", Offset = "0x2850120", VA = "0x182851B20")]
		public BadReadException(string message)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2851B80", Offset = "0x2850180", VA = "0x182851B80")]
		public BadReadException(string message, Exception innerException)
		{
		}
	}
}
