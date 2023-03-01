using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Grabber
{
	// Token: 0x020006F5 RID: 1781
	[Token(Token = "0x20006F5")]
	[AddComponentMenu("Sons/Gameplay/Grabber")]
	public class Grabber : MonoBehaviour
	{
		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06002DFC RID: 11772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005B4")]
		public static Collider FocusedCollider
		{
			[Token(Token = "0x6002DFC")]
			[Address(RVA = "0x2E13A00", Offset = "0x2E12A00", VA = "0x182E13A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06002DFD RID: 11773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005B5")]
		public static GameObject FocusedItemGO
		{
			[Token(Token = "0x6002DFD")]
			[Address(RVA = "0x2E13AF0", Offset = "0x2E12AF0", VA = "0x182E13AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06002DFE RID: 11774 RVA: 0x0000D140 File Offset: 0x0000B340
		[Token(Token = "0x170005B6")]
		public static bool IsFocused
		{
			[Token(Token = "0x6002DFE")]
			[Address(RVA = "0x2E13C30", Offset = "0x2E12C30", VA = "0x182E13C30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x0000D158 File Offset: 0x0000B358
		// (set) Token: 0x06002E00 RID: 11776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B7")]
		public static float FocusedTargetScore
		{
			[Token(Token = "0x6002DFF")]
			[Address(RVA = "0x2E13BE0", Offset = "0x2E12BE0", VA = "0x182E13BE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002E00")]
			[Address(RVA = "0x2E13D20", Offset = "0x2E12D20", VA = "0x182E13D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E02 RID: 11778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B8")]
		public static GameObject Filter
		{
			[Token(Token = "0x6002E01")]
			[Address(RVA = "0x2E139B0", Offset = "0x2E129B0", VA = "0x182E139B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E02")]
			[Address(RVA = "0x2E13CB0", Offset = "0x2E12CB0", VA = "0x182E13CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E03")]
		[Address(RVA = "0x2E13590", Offset = "0x2E12590", VA = "0x182E13590")]
		private void Start()
		{
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E04")]
		[Address(RVA = "0x2E137B0", Offset = "0x2E127B0", VA = "0x182E137B0")]
		private void Update()
		{
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E05")]
		[Address(RVA = "0x2E13220", Offset = "0x2E12220", VA = "0x182E13220")]
		private IGrabberTargetProvider GetHighestScoreTargetProvider(out float highestScore)
		{
			return null;
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E06")]
		[Address(RVA = "0x2E13460", Offset = "0x2E12460", VA = "0x182E13460")]
		public static void Register(IGrabberTargetProvider targetProvider)
		{
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E07")]
		[Address(RVA = "0x2E13730", Offset = "0x2E12730", VA = "0x182E13730")]
		public static void Unregister(IGrabberTargetProvider targetProvider)
		{
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E08")]
		[Address(RVA = "0x2E13640", Offset = "0x2E12640", VA = "0x182E13640")]
		private void ToggleGrabberDebug(bool show)
		{
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E09")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public Grabber()
		{
		}

		// Token: 0x040028EB RID: 10475
		[Token(Token = "0x40028EB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<IGrabberTargetProvider> TargetProviders;

		// Token: 0x040028EC RID: 10476
		[Token(Token = "0x40028EC")]
		[FieldOffset(Offset = "0x8")]
		private static IGrabberTargetProvider FocusedTargetProvider;
	}
}
