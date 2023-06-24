using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Grabber
{
	// Token: 0x02000843 RID: 2115
	[Token(Token = "0x2000843")]
	[AddComponentMenu("Sons/Gameplay/Grabber")]
	public class Grabber : MonoBehaviour
	{
		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06003BF0 RID: 15344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B7")]
		public static Collider FocusedCollider
		{
			[Token(Token = "0x6003BF0")]
			[Address(RVA = "0x3596E60", Offset = "0x3595460", VA = "0x183596E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B8")]
		public static GameObject FocusedItemGO
		{
			[Token(Token = "0x6003BF1")]
			[Address(RVA = "0x3596FE0", Offset = "0x35955E0", VA = "0x183596FE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06003BF2 RID: 15346 RVA: 0x000123D8 File Offset: 0x000105D8
		[Token(Token = "0x170007B9")]
		public static bool IsFocused
		{
			[Token(Token = "0x6003BF2")]
			[Address(RVA = "0x3597160", Offset = "0x3595760", VA = "0x183597160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06003BF3 RID: 15347 RVA: 0x000123F0 File Offset: 0x000105F0
		// (set) Token: 0x06003BF4 RID: 15348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007BA")]
		public static float FocusedTargetScore
		{
			[Token(Token = "0x6003BF3")]
			[Address(RVA = "0x35972E0", Offset = "0x35958E0", VA = "0x1835972E0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003BF4")]
			[Address(RVA = "0x3597330", Offset = "0x3595930", VA = "0x183597330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06003BF5 RID: 15349 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003BF6 RID: 15350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007BB")]
		public static GameObject Filter
		{
			[Token(Token = "0x6003BF5")]
			[Address(RVA = "0x3597390", Offset = "0x3595990", VA = "0x183597390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003BF6")]
			[Address(RVA = "0x35973E0", Offset = "0x35959E0", VA = "0x1835973E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BF7")]
		[Address(RVA = "0x3597490", Offset = "0x3595A90", VA = "0x183597490")]
		private void Start()
		{
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BF8")]
		[Address(RVA = "0x3597540", Offset = "0x3595B40", VA = "0x183597540")]
		private void Update()
		{
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF9")]
		[Address(RVA = "0x3597940", Offset = "0x3595F40", VA = "0x183597940")]
		private IGrabberTargetProvider GetHighestScoreTargetProvider(out float highestScore)
		{
			return null;
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BFA")]
		[Address(RVA = "0x3597BA0", Offset = "0x35961A0", VA = "0x183597BA0")]
		public static void Register(IGrabberTargetProvider targetProvider)
		{
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BFB")]
		[Address(RVA = "0x3597CE0", Offset = "0x35962E0", VA = "0x183597CE0")]
		public static void Unregister(IGrabberTargetProvider targetProvider)
		{
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BFC")]
		[Address(RVA = "0x3597D60", Offset = "0x3596360", VA = "0x183597D60")]
		private void ToggleGrabberDebug(bool show)
		{
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BFD")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public Grabber()
		{
		}

		// Token: 0x040032D0 RID: 13008
		[Token(Token = "0x40032D0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<IGrabberTargetProvider> TargetProviders;

		// Token: 0x040032D1 RID: 13009
		[Token(Token = "0x40032D1")]
		[FieldOffset(Offset = "0x8")]
		private static IGrabberTargetProvider FocusedTargetProvider;
	}
}
