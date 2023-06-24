using System;
using System.IO;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Breadcrumbs.Storage
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	internal interface IBreadcrumbFile
	{
		// Token: 0x060002DD RID: 733
		[Token(Token = "0x60002DD")]
		bool Exists();

		// Token: 0x060002DE RID: 734
		[Token(Token = "0x60002DE")]
		void Delete();

		// Token: 0x060002DF RID: 735
		[Token(Token = "0x60002DF")]
		Stream GetCreateStream();

		// Token: 0x060002E0 RID: 736
		[Token(Token = "0x60002E0")]
		Stream GetIOStream();

		// Token: 0x060002E1 RID: 737
		[Token(Token = "0x60002E1")]
		Stream GetWriteStream();
	}
}
