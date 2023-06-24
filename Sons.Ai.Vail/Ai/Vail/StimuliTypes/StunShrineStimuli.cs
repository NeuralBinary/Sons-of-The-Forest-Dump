using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001E8 RID: 488
	[Token(Token = "0x20001E8")]
	[AddComponentMenu("Sons/Stimuli/Stun Shrine Stimuli")]
	public class StunShrineStimuli : MonoBehaviourStimuli, IVailActorInteract
	{
		// Token: 0x06000E4A RID: 3658 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E4A")]
		[Address(RVA = "0x2BAB5D0", Offset = "0x2BA9BD0", VA = "0x182BAB5D0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E4B")]
		[Address(RVA = "0x2BAB600", Offset = "0x2BA9C00", VA = "0x182BAB600")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00008148 File Offset: 0x00006348
		[Token(Token = "0x6000E4C")]
		[Address(RVA = "0x22F41B0", Offset = "0x22F27B0", VA = "0x1822F41B0")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4D")]
		[Address(RVA = "0x2BAB6A0", Offset = "0x2BA9CA0", VA = "0x182BAB6A0")]
		public void Update()
		{
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4E")]
		[Address(RVA = "0x2BAB850", Offset = "0x2BA9E50", VA = "0x182BAB850")]
		public void BreakShrine()
		{
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4F")]
		[Address(RVA = "0x2BAC0A0", Offset = "0x2BAA6A0", VA = "0x182BAC0A0", Slot = "26")]
		public void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E50")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "27")]
		public void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x2BAC5C0", Offset = "0x2BAABC0", VA = "0x182BAC5C0", Slot = "28")]
		public void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E52")]
		[Address(RVA = "0x2BAC620", Offset = "0x2BAAC20", VA = "0x182BAC620")]
		public StunShrineStimuli()
		{
		}

		// Token: 0x040008EF RID: 2287
		[Token(Token = "0x40008EF")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Animator _skullAnimator;

		// Token: 0x040008F0 RID: 2288
		[Token(Token = "0x40008F0")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Animator _taserAnimator;

		// Token: 0x040008F1 RID: 2289
		[Token(Token = "0x40008F1")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _taserPickup;

		// Token: 0x040008F2 RID: 2290
		[Token(Token = "0x40008F2")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Transform _squirrelAnimRoot;

		// Token: 0x040008F3 RID: 2291
		[Token(Token = "0x40008F3")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private List<Rigidbody> _activateBodiesOnPickup;

		// Token: 0x040008F4 RID: 2292
		[Token(Token = "0x40008F4")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private List<Transform> _activateOnPickup;

		// Token: 0x040008F5 RID: 2293
		[Token(Token = "0x40008F5")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private List<Transform> _deactivateOnPickup;

		// Token: 0x040008F6 RID: 2294
		[Token(Token = "0x40008F6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int StunShrineHash;

		// Token: 0x040008F7 RID: 2295
		[Token(Token = "0x40008F7")]
		[FieldOffset(Offset = "0xE0")]
		private VailActor _interactingActor;

		// Token: 0x040008F8 RID: 2296
		[Token(Token = "0x40008F8")]
		[FieldOffset(Offset = "0xE8")]
		private bool _shrineBroken;
	}
}
