using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Gameplay;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006D1 RID: 1745
	[Token(Token = "0x20006D1")]
	[AddComponentMenu("Sons/Crafting/Structures/ScrewStructureDestruction")]
	public class ScrewStructureDestruction : EntityBehaviour, IImpactReceiverRemote, IImpactReceiver, IMonoBehaviour, IVailDamageableStructure, IIgnoreThrownLogDamage
	{
		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06002E12 RID: 11794 RVA: 0x0000D950 File Offset: 0x0000BB50
		// (set) Token: 0x06002E13 RID: 11795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061B")]
		public static bool StructureDestruction
		{
			[Token(Token = "0x6002E12")]
			[Address(RVA = "0x34463B0", Offset = "0x34449B0", VA = "0x1834463B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E13")]
			[Address(RVA = "0x34463F0", Offset = "0x34449F0", VA = "0x1834463F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E14")]
		[Address(RVA = "0x3446430", Offset = "0x3444A30", VA = "0x183446430")]
		private void AttackWithTestWeapon()
		{
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E15")]
		[Address(RVA = "0x34465B0", Offset = "0x3444BB0", VA = "0x1834465B0", Slot = "24")]
		private void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E16")]
		[Address(RVA = "0x3446A00", Offset = "0x3445000", VA = "0x183446A00")]
		public void DestroyStructure()
		{
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E17")]
		[Address(RVA = "0x3446DA0", Offset = "0x34453A0", VA = "0x183446DA0", Slot = "17")]
		public override void Detached()
		{
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E18")]
		[Address(RVA = "0x3446E50", Offset = "0x3445450", VA = "0x183446E50")]
		private void BreakRenderersFX()
		{
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E19")]
		[Address(RVA = "0x3447920", Offset = "0x3445F20", VA = "0x183447920")]
		private IEnumerator Routine(float duration, List<Renderer> renderers, List<Vector3> forces)
		{
			return null;
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E1A")]
		[Address(RVA = "0x3447AA0", Offset = "0x34460A0", VA = "0x183447AA0")]
		public ScrewStructureDestruction()
		{
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E1B")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "25")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E1C")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "26")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x0000D968 File Offset: 0x0000BB68
		[Token(Token = "0x6002E1D")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04002838 RID: 10296
		[Token(Token = "0x4002838")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sons.Gameplay.MeleeWeapon _testWeapon;

		// Token: 0x04002839 RID: 10297
		[Token(Token = "0x4002839")]
		[FieldOffset(Offset = "0x30")]
		private int _currentHp;

		// Token: 0x0400283A RID: 10298
		[Token(Token = "0x400283A")]
		private const string BreakSfx = "event:/SotF Events/player sounds/Build Sounds/build_break_apart";
	}
}
