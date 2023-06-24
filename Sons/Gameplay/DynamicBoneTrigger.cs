using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000761 RID: 1889
	[Token(Token = "0x2000761")]
	[AddComponentMenu("Sons/Gameplay/Dynamic Bone Trigger")]
	public class DynamicBoneTrigger : MonoBehaviour
	{
		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06003314 RID: 13076 RVA: 0x0000F558 File Offset: 0x0000D758
		[Token(Token = "0x17000690")]
		private bool BlocksVision
		{
			[Token(Token = "0x6003314")]
			[Address(RVA = "0x34AF9B0", Offset = "0x34ADFB0", VA = "0x1834AF9B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x0000F570 File Offset: 0x0000D770
		[Token(Token = "0x6003315")]
		[Address(RVA = "0x34AF9C0", Offset = "0x34ADFC0", VA = "0x1834AF9C0")]
		private bool IsInvalidSetup()
		{
			return default(bool);
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003316")]
		[Address(RVA = "0x34AFAA0", Offset = "0x34AE0A0", VA = "0x1834AFAA0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003317")]
		[Address(RVA = "0x34AFAB0", Offset = "0x34AE0B0", VA = "0x1834AFAB0")]
		private void UpdatePlayerBushCover(Component other, bool add)
		{
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x0000F588 File Offset: 0x0000D788
		[Token(Token = "0x6003318")]
		[Address(RVA = "0x34AFCF0", Offset = "0x34AE2F0", VA = "0x1834AFCF0")]
		public float GetVisionBlock(Vector3 pos)
		{
			return 0f;
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003319")]
		[Address(RVA = "0x34AFED0", Offset = "0x34AE4D0", VA = "0x1834AFED0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331A")]
		[Address(RVA = "0x34B0050", Offset = "0x34AE650", VA = "0x1834B0050")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331B")]
		[Address(RVA = "0x34B0190", Offset = "0x34AE790", VA = "0x1834B0190")]
		private void OnDisable()
		{
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331C")]
		[Address(RVA = "0x34B03C0", Offset = "0x34AE9C0", VA = "0x1834B03C0")]
		private void UpdateBones()
		{
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331D")]
		[Address(RVA = "0x34B0570", Offset = "0x34AEB70", VA = "0x1834B0570")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331E")]
		[Address(RVA = "0x34B07C0", Offset = "0x34AEDC0", VA = "0x1834B07C0")]
		private void RecollectBones()
		{
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331F")]
		[Address(RVA = "0x34B08A0", Offset = "0x34AEEA0", VA = "0x1834B08A0")]
		public DynamicBoneTrigger()
		{
		}

		// Token: 0x04002C0E RID: 11278
		[Token(Token = "0x4002C0E")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _visionBlock;

		// Token: 0x04002C0F RID: 11279
		[Token(Token = "0x4002C0F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector2 _visionBlockRadiusRange;

		// Token: 0x04002C10 RID: 11280
		[Token(Token = "0x4002C10")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<DynamicBone> _bones;

		// Token: 0x04002C11 RID: 11281
		[Token(Token = "0x4002C11")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<DynamicBoneColliderBase> _knownColliders;
	}
}
