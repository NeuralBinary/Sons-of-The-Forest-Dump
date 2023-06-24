using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[Serializable]
	public class MessageTarget : ActionTemplate
	{
		// Token: 0x06000068 RID: 104 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2D1E930", Offset = "0x2D1CF30", VA = "0x182D1E930", Slot = "5")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2D1E950", Offset = "0x2D1CF50", VA = "0x182D1E950", Slot = "11")]
		internal override bool Start()
		{
			return default(bool);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2D1E9B0", Offset = "0x2D1CFB0", VA = "0x182D1E9B0")]
		public MessageTarget()
		{
		}

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected MessageTarget.Target _target;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		protected MessageTarget.Message _targetMessage;

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x2000017")]
		public enum Message
		{
			// Token: 0x04000086 RID: 134
			[Token(Token = "0x4000086")]
			DieNow,
			// Token: 0x04000087 RID: 135
			[Token(Token = "0x4000087")]
			GetClean,
			// Token: 0x04000088 RID: 136
			[Token(Token = "0x4000088")]
			TriggerStateFX,
			// Token: 0x04000089 RID: 137
			[Token(Token = "0x4000089")]
			DropPrey,
			// Token: 0x0400008A RID: 138
			[Token(Token = "0x400008A")]
			Grabbed,
			// Token: 0x0400008B RID: 139
			[Token(Token = "0x400008B")]
			ReachedStimuli,
			// Token: 0x0400008C RID: 140
			[Token(Token = "0x400008C")]
			DropCarriedItems,
			// Token: 0x0400008D RID: 141
			[Token(Token = "0x400008D")]
			SearchNearbyBushes,
			// Token: 0x0400008E RID: 142
			[Token(Token = "0x400008E")]
			Alerted,
			// Token: 0x0400008F RID: 143
			[Token(Token = "0x400008F")]
			GoRagdoll,
			// Token: 0x04000090 RID: 144
			[Token(Token = "0x4000090")]
			FinishConsume,
			// Token: 0x04000091 RID: 145
			[Token(Token = "0x4000091")]
			RecoverFromInjured,
			// Token: 0x04000092 RID: 146
			[Token(Token = "0x4000092")]
			CeilingWalk
		}

		// Token: 0x02000018 RID: 24
		[Token(Token = "0x2000018")]
		public enum Target
		{
			// Token: 0x04000094 RID: 148
			[Token(Token = "0x4000094")]
			StimuliActor,
			// Token: 0x04000095 RID: 149
			[Token(Token = "0x4000095")]
			Self
		}
	}
}
