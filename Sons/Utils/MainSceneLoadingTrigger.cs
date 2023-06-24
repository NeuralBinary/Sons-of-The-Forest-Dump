using System;
using Il2CppDummyDll;
using Sons.Loading;
using UnityEngine;

namespace Sons.Utils
{
	// Token: 0x020004E7 RID: 1255
	[Token(Token = "0x20004E7")]
	[AddComponentMenu("Sons/Utils/MainSceneLoadingTrigger")]
	public class MainSceneLoadingTrigger : SceneLoadingListener
	{
		// Token: 0x060020F5 RID: 8437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F5")]
		[Address(RVA = "0x331EB10", Offset = "0x331D110", VA = "0x18331EB10", Slot = "10")]
		public override void Completed()
		{
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F6")]
		[Address(RVA = "0x331EB70", Offset = "0x331D170", VA = "0x18331EB70")]
		private void LateUpdate()
		{
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F7")]
		[Address(RVA = "0x331ED20", Offset = "0x331D320", VA = "0x18331ED20", Slot = "7")]
		public override void OnEnable()
		{
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F8")]
		[Address(RVA = "0x331EE10", Offset = "0x331D410", VA = "0x18331EE10")]
		public MainSceneLoadingTrigger()
		{
		}

		// Token: 0x04001E91 RID: 7825
		[Token(Token = "0x4001E91")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _completeWaitTrigger;

		// Token: 0x04001E92 RID: 7826
		[Token(Token = "0x4001E92")]
		[FieldOffset(Offset = "0x3C")]
		private float _completedTime;

		// Token: 0x04001E93 RID: 7827
		[Token(Token = "0x4001E93")]
		[FieldOffset(Offset = "0x40")]
		private bool _triggered;
	}
}
