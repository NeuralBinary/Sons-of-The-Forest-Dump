using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	public class ComHelper
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ComHelper()
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002054 File Offset: 0x00000254
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2850460", Offset = "0x284EA60", VA = "0x182850460")]
		public bool IsZipFile(string filename)
		{
			return default(bool);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x28504E0", Offset = "0x284EAE0", VA = "0x1828504E0")]
		public bool IsZipFileWithExtract(string filename)
		{
			return default(bool);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2850530", Offset = "0x284EB30", VA = "0x182850530")]
		public bool CheckZip(string filename)
		{
			return default(bool);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x28505B0", Offset = "0x284EBB0", VA = "0x1828505B0")]
		public bool CheckZipPassword(string filename, string password)
		{
			return default(bool);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2850610", Offset = "0x284EC10", VA = "0x182850610")]
		public void FixZipDirectory(string filename)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2850660", Offset = "0x284EC60", VA = "0x182850660")]
		public string GetZipLibraryVersion()
		{
			return null;
		}
	}
}
