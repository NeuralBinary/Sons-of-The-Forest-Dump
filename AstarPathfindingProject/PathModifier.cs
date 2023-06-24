using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	[Serializable]
	public abstract class PathModifier : IPathModifier
	{
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000792 RID: 1938
		[Token(Token = "0x1700012F")]
		public abstract int Order { [Token(Token = "0x6000792")] get; }

		// Token: 0x06000793 RID: 1939 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x6C2960", Offset = "0x6C0F60", VA = "0x1806C2960")]
		public void Awake(Seeker seeker)
		{
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x6C2A70", Offset = "0x6C1070", VA = "0x1806C2A70")]
		public void OnDestroy(Seeker seeker)
		{
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public virtual void PreProcess(Path path)
		{
		}

		// Token: 0x06000796 RID: 1942
		[Token(Token = "0x6000796")]
		public abstract void Apply(Path path);

		// Token: 0x06000797 RID: 1943 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected PathModifier()
		{
		}

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		public Seeker seeker;
	}
}
