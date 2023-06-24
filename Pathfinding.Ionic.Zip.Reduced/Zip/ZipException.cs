using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00006")]
	public class ZipException : Exception
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2851AD0", Offset = "0x28500D0", VA = "0x182851AD0")]
		public ZipException()
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2851B20", Offset = "0x2850120", VA = "0x182851B20")]
		public ZipException(string message)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2851B80", Offset = "0x2850180", VA = "0x182851B80")]
		public ZipException(string message, Exception innerException)
		{
		}
	}
}
