using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001DC RID: 476
	[Token(Token = "0x20001DC")]
	public abstract class RobbyOrderStimuliBase : MonoBehaviourStimuli
	{
		// Token: 0x06000E03 RID: 3587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x13428C0", Offset = "0x1340EC0", VA = "0x1813428C0", Slot = "26")]
		public virtual void Initialize(VailActor ownerActor)
		{
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x2BA9630", Offset = "0x2BA7C30", VA = "0x182BA9630")]
		protected IRobbyCallbacks GetRobbyCallbacks(VailActor actor)
		{
			return null;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00007F08 File Offset: 0x00006108
		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x2BA9710", Offset = "0x2BA7D10", VA = "0x182BA9710")]
		public bool IsValidForActor(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00007F20 File Offset: 0x00006120
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x2BA98F0", Offset = "0x2BA7EF0", VA = "0x182BA98F0", Slot = "12")]
		public override bool Validate(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		protected RobbyOrderStimuliBase()
		{
		}

		// Token: 0x040008DC RID: 2268
		[Token(Token = "0x40008DC")]
		[FieldOffset(Offset = "0xA8")]
		private VailActor _ownerActor;
	}
}
