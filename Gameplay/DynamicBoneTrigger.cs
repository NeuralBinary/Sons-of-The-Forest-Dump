using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000644 RID: 1604
	[Token(Token = "0x2000644")]
	[AddComponentMenu("Sons/Gameplay/Dynamic Bone Trigger")]
	public class DynamicBoneTrigger : MonoBehaviour
	{
		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06002934 RID: 10548 RVA: 0x0000BE98 File Offset: 0x0000A098
		[Token(Token = "0x17000564")]
		private bool BlocksVision
		{
			[Token(Token = "0x6002934")]
			[Address(RVA = "0x2DC8400", Offset = "0x2DC7400", VA = "0x182DC8400")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		[Token(Token = "0x6002935")]
		[Address(RVA = "0x2DC7BF0", Offset = "0x2DC6BF0", VA = "0x182DC7BF0")]
		private bool IsInvalidSetup()
		{
			return default(bool);
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002936")]
		[Address(RVA = "0x2DC80C0", Offset = "0x2DC70C0", VA = "0x182DC80C0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002937")]
		[Address(RVA = "0x2DC82A0", Offset = "0x2DC72A0", VA = "0x182DC82A0")]
		private void UpdatePlayerBushCover(Component other, bool add)
		{
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		[Token(Token = "0x6002938")]
		[Address(RVA = "0x2DC7A90", Offset = "0x2DC6A90", VA = "0x182DC7A90")]
		public float GetVisionBlock(Vector3 pos)
		{
			return default(float);
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002939")]
		[Address(RVA = "0x2DC7EC0", Offset = "0x2DC6EC0", VA = "0x182DC7EC0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600293A")]
		[Address(RVA = "0x2DC7FF0", Offset = "0x2DC6FF0", VA = "0x182DC7FF0")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600293B")]
		[Address(RVA = "0x2DC7C60", Offset = "0x2DC6C60", VA = "0x182DC7C60")]
		private void OnDisable()
		{
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600293C")]
		[Address(RVA = "0x2DC8170", Offset = "0x2DC7170", VA = "0x182DC8170")]
		private void UpdateBones()
		{
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600293D")]
		[Address(RVA = "0x2DC7DF0", Offset = "0x2DC6DF0", VA = "0x182DC7DF0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600293E")]
		[Address(RVA = "0x2DC80D0", Offset = "0x2DC70D0", VA = "0x182DC80D0")]
		private void RecollectBones()
		{
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600293F")]
		[Address(RVA = "0x2DC8370", Offset = "0x2DC7370", VA = "0x182DC8370")]
		public DynamicBoneTrigger()
		{
		}

		// Token: 0x040024CA RID: 9418
		[Token(Token = "0x40024CA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _visionBlock;

		// Token: 0x040024CB RID: 9419
		[Token(Token = "0x40024CB")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector2 _visionBlockRadiusRange;

		// Token: 0x040024CC RID: 9420
		[Token(Token = "0x40024CC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<DynamicBone> _bones;

		// Token: 0x040024CD RID: 9421
		[Token(Token = "0x40024CD")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<DynamicBoneColliderBase> _knownColliders;
	}
}
