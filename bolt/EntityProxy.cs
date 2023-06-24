using System;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000039 RID: 57
[Token(Token = "0x2000039")]
internal class EntityProxy : BitSet
{
	// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000246")]
	[Address(RVA = "0x79E7B0", Offset = "0x79CDB0", VA = "0x18079E7B0")]
	public EntityProxy()
	{
	}

	// Token: 0x06000247 RID: 583 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000247")]
	[Address(RVA = "0x79E880", Offset = "0x79CE80", VA = "0x18079E880")]
	public EntityProxyEnvelope CreateEnvelope()
	{
		return null;
	}

	// Token: 0x06000248 RID: 584 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000248")]
	[Address(RVA = "0x79EB80", Offset = "0x79D180", VA = "0x18079EB80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x04000127 RID: 295
	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0xA8")]
	public NetworkState State;

	// Token: 0x04000128 RID: 296
	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0xB0")]
	public NetworkId NetworkId;

	// Token: 0x04000129 RID: 297
	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0xB8")]
	public ProxyFlags Flags;

	// Token: 0x0400012A RID: 298
	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0xC0")]
	public Priority[] PropertyPriority;

	// Token: 0x0400012B RID: 299
	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0xC8")]
	public Entity Entity;

	// Token: 0x0400012C RID: 300
	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0xD0")]
	public BoltConnection Connection;

	// Token: 0x0400012D RID: 301
	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0xD8")]
	public Queue<EntityProxyEnvelope> Envelopes;

	// Token: 0x0400012E RID: 302
	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0xE0")]
	public IProtocolToken ControlTokenLost;

	// Token: 0x0400012F RID: 303
	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0xE8")]
	public IProtocolToken ControlTokenGained;

	// Token: 0x04000130 RID: 304
	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0xF0")]
	public int Skipped;

	// Token: 0x04000131 RID: 305
	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0xF4")]
	public float Priority;

	// Token: 0x04000132 RID: 306
	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0xF8")]
	public bool DestroyRequested;

	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public class PriorityComparer : IComparer<EntityProxy>
	{
		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private PriorityComparer()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x79EC10", Offset = "0x79D210", VA = "0x18079EC10", Slot = "4")]
		private int Compare(EntityProxy x, EntityProxy y)
		{
			return 0;
		}

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x0")]
		public static readonly EntityProxy.PriorityComparer Instance;
	}
}
