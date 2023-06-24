using System;
using Il2CppDummyDll;
using Sons.Weapon;

namespace Sons.Ai.Vail
{
	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	public class DamageReceivedStimuli : IStimuli
	{
		// Token: 0x0600067F RID: 1663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x2B3ED40", Offset = "0x2B3D340", VA = "0x182B3ED40")]
		public DamageReceivedStimuli(IDamageCallbackSender senderNode, ImpactType impactType, float amount, MonoBehaviourStimuli sourceStimuli)
		{
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00005010 File Offset: 0x00003210
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x2B3EE50", Offset = "0x2B3D450", VA = "0x182B3EE50", Slot = "4")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x1700006D")]
		public MonoBehaviourStimuli SourceStimuli
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x2B3EEB0", Offset = "0x2B3D4B0", VA = "0x182B3EEB0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x2B3EEE0", Offset = "0x2B3D4E0", VA = "0x182B3EEE0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00005028 File Offset: 0x00003228
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
		public virtual bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x2B3EF60", Offset = "0x2B3D560", VA = "0x182B3EF60", Slot = "6")]
		public string GetLog()
		{
			return null;
		}

		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		private const float ExpireTime = 2f;

		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x10")]
		private IDamageCallbackSender _senderNode;

		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x18")]
		private ImpactType _impactType;

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x1C")]
		private float _amount;

		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x20")]
		private MonoBehaviourStimuli _sourceStimuli;

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x28")]
		private int _frame;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x2C")]
		private float _impactTime;
	}
}
