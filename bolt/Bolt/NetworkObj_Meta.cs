using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	internal abstract class NetworkObj_Meta
	{
		// Token: 0x06000555 RID: 1365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x8ECCF0", Offset = "0x8EB2F0", VA = "0x1808ECCF0")]
		internal NetworkObj_Meta()
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x8ED1A0", Offset = "0x8EB7A0", VA = "0x1808ED1A0")]
		internal NetworkStorage AllocateStorage()
		{
			return null;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x8ED2E0", Offset = "0x8EB8E0", VA = "0x1808ED2E0")]
		internal void FreeStorage(NetworkStorage storage)
		{
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x8ED400", Offset = "0x8EBA00", VA = "0x1808ED400")]
		private void AddPropertyToArray(int offsetProperties, int offsetObjects, NetworkProperty property)
		{
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x8ED5C0", Offset = "0x8EBBC0", VA = "0x1808ED5C0")]
		internal void AddProperty(int offsetProperties, int offsetObjects, NetworkProperty property, int arrayIndex)
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x8ED880", Offset = "0x8EBE80", VA = "0x1808ED880")]
		private void AddCopiedProperty(int offsetProperties, int offsetObjects, NetworkPropertyInfo property, string prefix, int arrayIndex)
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x8EDF60", Offset = "0x8EC560", VA = "0x1808EDF60")]
		internal void CopyProperties(int offsetProperties, int offsetObjects, NetworkObj_Meta meta, string prefix, int arrayIndex)
		{
		}

		// Token: 0x0600055C RID: 1372
		[Token(Token = "0x600055C")]
		internal abstract void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets);

		// Token: 0x0600055D RID: 1373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x8EE040", Offset = "0x8EC640", VA = "0x1808EE040", Slot = "5")]
		internal virtual void InitMeta()
		{
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x8EE3E0", Offset = "0x8EC9E0", VA = "0x1808EE3E0")]
		internal void InitObject(NetworkObj obj, NetworkObj root, NetworkObj_Meta.Offsets offsets)
		{
		}

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] ZeroIndices;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] ZeroPaths;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x10")]
		internal TypeId TypeId;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x18")]
		internal BitSet[] Filters;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x20")]
		internal Priority[] PropertiesTempPriority;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x28")]
		internal NetworkPropertyInfo[] Properties;

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x30")]
		internal HashSet<string> CallbackPaths;

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x38")]
		internal Stack<NetworkStorage> StoragePool;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x40")]
		internal List<NetworkPropertyInfo> OnRender;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x48")]
		internal List<NetworkPropertyInfo> OnSimulateAfter;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x50")]
		internal List<NetworkPropertyInfo> OnSimulateBefore;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x58")]
		internal List<NetworkPropertyInfo> OnControlGainedLost;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x60")]
		internal List<NetworkPropertyInfo> OnFrameCloned;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x68")]
		internal int CountObjects;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x6C")]
		internal int CountStorage;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x70")]
		internal int CountProperties;

		// Token: 0x020000AE RID: 174
		[Token(Token = "0x20000AE")]
		internal struct Offsets
		{
			// Token: 0x06000560 RID: 1376 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x8EE670", Offset = "0x8ECC70", VA = "0x1808EE670")]
			internal Offsets(int properties, int storage, int objects)
			{
			}

			// Token: 0x0400029D RID: 669
			[Token(Token = "0x400029D")]
			[FieldOffset(Offset = "0x0")]
			internal int OffsetStorage;

			// Token: 0x0400029E RID: 670
			[Token(Token = "0x400029E")]
			[FieldOffset(Offset = "0x4")]
			internal int OffsetObjects;

			// Token: 0x0400029F RID: 671
			[Token(Token = "0x400029F")]
			[FieldOffset(Offset = "0x8")]
			internal int OffsetProperties;
		}
	}
}
