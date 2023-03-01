using System;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000455 RID: 1109
	[Token(Token = "0x2000455")]
	[Serializable]
	public class StarLocationCondition : ACondition
	{
		// Token: 0x06001C3B RID: 7227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3B")]
		[Address(RVA = "0x2D04170", Offset = "0x2D03170", VA = "0x182D04170", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3C")]
		[Address(RVA = "0x2D04060", Offset = "0x2D03060", VA = "0x182D04060", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3D")]
		[Address(RVA = "0x2D04270", Offset = "0x2D03270", VA = "0x182D04270", Slot = "10")]
		public virtual void OnStarLocationVisited(object o)
		{
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3E")]
		[Address(RVA = "0x2CF3FC0", Offset = "0x2CF2FC0", VA = "0x182CF3FC0")]
		public StarLocationCondition()
		{
		}

		// Token: 0x04001AF8 RID: 6904
		[Token(Token = "0x4001AF8")]
		[FieldOffset(Offset = "0x20")]
		public int _starNumber;
	}
}
