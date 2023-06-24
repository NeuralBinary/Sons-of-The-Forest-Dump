using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x02000952 RID: 2386
	[Token(Token = "0x2000952")]
	public class MaskTrigger : MonoBehaviour
	{
		// Token: 0x06004517 RID: 17687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004517")]
		[Address(RVA = "0x365E300", Offset = "0x365C900", VA = "0x18365E300")]
		private void Update()
		{
		}

		// Token: 0x06004518 RID: 17688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004518")]
		[Address(RVA = "0x365E8E0", Offset = "0x365CEE0", VA = "0x18365E8E0")]
		private void DoActivateTrigger()
		{
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004519")]
		[Address(RVA = "0x365EC80", Offset = "0x365D280", VA = "0x18365EC80")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600451A")]
		[Address(RVA = "0x365EF20", Offset = "0x365D520", VA = "0x18365EF20")]
		public MaskTrigger()
		{
		}

		// Token: 0x040047C0 RID: 18368
		[Token(Token = "0x40047C0")]
		[FieldOffset(Offset = "0x20")]
		private bool _runningSequence;

		// Token: 0x040047C1 RID: 18369
		[Token(Token = "0x40047C1")]
		[FieldOffset(Offset = "0x21")]
		private bool _needsFinish;

		// Token: 0x040047C2 RID: 18370
		[Token(Token = "0x40047C2")]
		[FieldOffset(Offset = "0x24")]
		private int _animationHash;

		// Token: 0x040047C3 RID: 18371
		[Token(Token = "0x40047C3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _alignTransform;

		// Token: 0x040047C4 RID: 18372
		[Token(Token = "0x40047C4")]
		[FieldOffset(Offset = "0x30")]
		private bool _hasStarted;

		// Token: 0x040047C5 RID: 18373
		[Token(Token = "0x40047C5")]
		[FieldOffset(Offset = "0x38")]
		private Animator _animator;
	}
}
