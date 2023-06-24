using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	[Serializable]
	public abstract class MonoModifier : VersionedMonoBehaviour, IPathModifier
	{
		// Token: 0x06000798 RID: 1944 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x6C2B70", Offset = "0x6C1170", VA = "0x1806C2B70", Slot = "13")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x6C2CC0", Offset = "0x6C12C0", VA = "0x1806C2CC0", Slot = "14")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600079A RID: 1946
		[Token(Token = "0x17000130")]
		public abstract int Order { [Token(Token = "0x600079A")] get; }

		// Token: 0x0600079B RID: 1947 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "16")]
		public virtual void PreProcess(Path path)
		{
		}

		// Token: 0x0600079C RID: 1948
		[Token(Token = "0x600079C")]
		public abstract void Apply(Path path);

		// Token: 0x0600079D RID: 1949 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected MonoModifier()
		{
		}

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Seeker seeker;
	}
}
