using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x20001E6")]
	[AddComponentMenu("Sons/Stimuli/StructureAttackStimuli")]
	public class StructureAttackStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000E36 RID: 3638 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E36")]
		[Address(RVA = "0x2BAA480", Offset = "0x2BA8A80", VA = "0x182BAA480")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E37")]
		[Address(RVA = "0x2BAA4B0", Offset = "0x2BA8AB0", VA = "0x182BAA4B0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00008058 File Offset: 0x00006258
		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00008070 File Offset: 0x00006270
		[Token(Token = "0x6000E39")]
		[Address(RVA = "0x2BAA530", Offset = "0x2BA8B30", VA = "0x182BAA530", Slot = "11")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00008088 File Offset: 0x00006288
		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x2BAA640", Offset = "0x2BA8C40", VA = "0x182BAA640", Slot = "12")]
		public override bool Validate(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x2BAA770", Offset = "0x2BA8D70", VA = "0x182BAA770")]
		public void Initialize(VailActor actor, Transform targetTr)
		{
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public StructureAttackStimuli()
		{
		}

		// Token: 0x040008E4 RID: 2276
		[Token(Token = "0x40008E4")]
		[FieldOffset(Offset = "0xA8")]
		private VailActor _validActor;

		// Token: 0x040008E5 RID: 2277
		[Token(Token = "0x40008E5")]
		[FieldOffset(Offset = "0xB0")]
		private Transform _structureTransform;
	}
}
