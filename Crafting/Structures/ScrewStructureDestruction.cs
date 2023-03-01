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
	// Token: 0x020007C5 RID: 1989
	[Token(Token = "0x20007C5")]
	[AddComponentMenu("Sons/Crafting/Structures/ScrewStructureDestruction")]
	public class ScrewStructureDestruction : EntityBehaviour, IImpactReceiverRemote, IImpactReceiver, IMonoBehaviour, IVailDamageableStructure, IIgnoreThrownLogDamage
	{
		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x0600347E RID: 13438 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		// (set) Token: 0x0600347F RID: 13439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006AC")]
		public static bool StructureDestruction
		{
			[Token(Token = "0x600347E")]
			[Address(RVA = "0x2E969A0", Offset = "0x2E959A0", VA = "0x182E969A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600347F")]
			[Address(RVA = "0x2E969E0", Offset = "0x2E959E0", VA = "0x182E969E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003480")]
		[Address(RVA = "0x2E95A50", Offset = "0x2E94A50", VA = "0x182E95A50")]
		private void AttackWithTestWeapon()
		{
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003481")]
		[Address(RVA = "0x2E965A0", Offset = "0x2E955A0", VA = "0x182E965A0", Slot = "24")]
		private void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003482")]
		[Address(RVA = "0x2E962A0", Offset = "0x2E952A0", VA = "0x182E962A0")]
		public void DestroyStructure()
		{
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003483")]
		[Address(RVA = "0x2E96520", Offset = "0x2E95520", VA = "0x182E96520", Slot = "17")]
		public override void Detached()
		{
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003484")]
		[Address(RVA = "0x2E95C00", Offset = "0x2E94C00", VA = "0x182E95C00")]
		private void BreakRenderersFX()
		{
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003485")]
		[Address(RVA = "0x2E968E0", Offset = "0x2E958E0", VA = "0x182E968E0")]
		private IEnumerator Routine(float duration, List<Renderer> renderers, List<Vector3> forces)
		{
			return null;
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003486")]
		[Address(RVA = "0x2E96990", Offset = "0x2E95990", VA = "0x182E96990")]
		public ScrewStructureDestruction()
		{
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003487")]
		[Address(RVA = "0x288E5E0", Offset = "0x288D5E0", VA = "0x18288E5E0", Slot = "25")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003488")]
		[Address(RVA = "0x5E9620", Offset = "0x5E8620", VA = "0x1805E9620", Slot = "26")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		[Token(Token = "0x6003489")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04002D55 RID: 11605
		[Token(Token = "0x4002D55")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeleeWeapon _testWeapon;

		// Token: 0x04002D56 RID: 11606
		[Token(Token = "0x4002D56")]
		[FieldOffset(Offset = "0x30")]
		private int _hp;
	}
}
