using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	public abstract class NetworkObj
	{
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010C")]
		internal NetworkState RootState
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x8F2290", Offset = "0x8F0890", VA = "0x1808F2290")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x8F2300", Offset = "0x8F0900", VA = "0x1808F2300")]
		internal void Add()
		{
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010D")]
		internal List<NetworkObj> Objects
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x8F2390", Offset = "0x8F0990", VA = "0x1808F2390")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010E")]
		internal virtual NetworkStorage Storage
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x8F23B0", Offset = "0x8F09B0", VA = "0x1808F23B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		internal NetworkObj(NetworkObj_Meta meta)
		{
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x8F23E0", Offset = "0x8F09E0", VA = "0x1808F23E0")]
		internal void InitRoot()
		{
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x8F2540", Offset = "0x8F0B40", VA = "0x1808F2540")]
		internal void Init(string path, NetworkObj parent, NetworkObj_Meta.Offsets offsets)
		{
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x8F25D0", Offset = "0x8F0BD0", VA = "0x1808F25D0")]
		internal NetworkStorage AllocateStorage()
		{
			return null;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x8F2720", Offset = "0x8F0D20", VA = "0x1808F2720")]
		internal NetworkStorage DuplicateStorage(NetworkStorage s)
		{
			return null;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x8F27F0", Offset = "0x8F0DF0", VA = "0x1808F27F0")]
		internal void FreeStorage(NetworkStorage storage)
		{
		}

		// Token: 0x1700010F RID: 271
		[Token(Token = "0x1700010F")]
		internal int this[NetworkProperty property]
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x8F2810", Offset = "0x8F0E10", VA = "0x1808F2810")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x10")]
		internal string Path;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x18")]
		internal NetworkObj Root;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x20")]
		internal List<NetworkObj> RootObjects;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x28")]
		internal readonly NetworkObj_Meta Meta;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x30")]
		internal int OffsetObjects;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x34")]
		internal int OffsetStorage;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x38")]
		internal int OffsetProperties;
	}
}
