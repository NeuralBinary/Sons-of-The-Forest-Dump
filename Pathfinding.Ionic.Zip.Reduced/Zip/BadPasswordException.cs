using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000B")]
	public class BadPasswordException : ZipException
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2851AD0", Offset = "0x28500D0", VA = "0x182851AD0")]
		public BadPasswordException()
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2851B20", Offset = "0x2850120", VA = "0x182851B20")]
		public BadPasswordException(string message)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2851B80", Offset = "0x2850180", VA = "0x182851B80")]
		public BadPasswordException(string message, Exception innerException)
		{
		}
	}
}
