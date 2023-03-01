using System;
using Il2CppDummyDll;
using Sons.Loading;
using UnityEngine;

namespace Sons.Utils
{
	// Token: 0x020004ED RID: 1261
	[Token(Token = "0x20004ED")]
	[AddComponentMenu("Sons/Utils/MainSceneLoadingTrigger")]
	public class MainSceneLoadingTrigger : SceneLoadingListener
	{
		// Token: 0x06002059 RID: 8281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002059")]
		[Address(RVA = "0x2D2BBA0", Offset = "0x2D2ABA0", VA = "0x182D2BBA0", Slot = "10")]
		public override void Completed()
		{
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600205A")]
		[Address(RVA = "0x2D2BBC0", Offset = "0x2D2ABC0", VA = "0x182D2BBC0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600205B")]
		[Address(RVA = "0x2D2BC90", Offset = "0x2D2AC90", VA = "0x182D2BC90", Slot = "7")]
		public override void OnEnable()
		{
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600205C")]
		[Address(RVA = "0x2D2BD10", Offset = "0x2D2AD10", VA = "0x182D2BD10")]
		public MainSceneLoadingTrigger()
		{
		}

		// Token: 0x04001E21 RID: 7713
		[Token(Token = "0x4001E21")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _completeWaitTrigger;

		// Token: 0x04001E22 RID: 7714
		[Token(Token = "0x4001E22")]
		[FieldOffset(Offset = "0x3C")]
		private float _completedTime;

		// Token: 0x04001E23 RID: 7715
		[Token(Token = "0x4001E23")]
		[FieldOffset(Offset = "0x40")]
		private bool _triggered;
	}
}
