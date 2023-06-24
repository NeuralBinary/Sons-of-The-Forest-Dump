using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001ED RID: 493
	[Token(Token = "0x20001ED")]
	[AddComponentMenu("Sons/Stimuli/Tree Stimuli")]
	public class TreeStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000E68 RID: 3688 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E68")]
		[Address(RVA = "0x2BAD2F0", Offset = "0x2BAB8F0", VA = "0x182BAD2F0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E69")]
		[Address(RVA = "0x2BAD320", Offset = "0x2BAB920", VA = "0x182BAD320")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x000081D8 File Offset: 0x000063D8
		[Token(Token = "0x6000E6A")]
		[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0x2BAD3A0", Offset = "0x2BAB9A0", VA = "0x182BAD3A0")]
		private TreeStimuli()
		{
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6C")]
		[Address(RVA = "0x2BAD3E0", Offset = "0x2BAB9E0", VA = "0x182BAD3E0")]
		public void SetRadius(float radius)
		{
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x000081F0 File Offset: 0x000063F0
		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x2403F30", Offset = "0x2402530", VA = "0x182403F30")]
		public float GetRadius()
		{
			return 0f;
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00008208 File Offset: 0x00006408
		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0x2BAD3F0", Offset = "0x2BAB9F0", VA = "0x182BAD3F0", Slot = "19")]
		public override bool GetSnapToTarget(VailActor vailActor, bool allowReserveLoc, out Vector3 position, out Quaternion rotation)
		{
			return default(bool);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0x2BAD730", Offset = "0x2BABD30", VA = "0x182BAD730", Slot = "24")]
		protected override void OnDrawGizmosSelected()
		{
		}

		// Token: 0x040008FB RID: 2299
		[Token(Token = "0x40008FB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _treeRadius;
	}
}
