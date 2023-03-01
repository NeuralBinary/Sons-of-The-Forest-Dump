using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008DB RID: 2267
	[Token(Token = "0x20008DB")]
	public class MaskTrigger : MonoBehaviour
	{
		// Token: 0x06003DA8 RID: 15784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA8")]
		[Address(RVA = "0x2F1FF00", Offset = "0x2F1EF00", VA = "0x182F1FF00")]
		private void Update()
		{
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA9")]
		[Address(RVA = "0x2F1FAC0", Offset = "0x2F1EAC0", VA = "0x182F1FAC0")]
		private void DoActivateTrigger()
		{
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DAA")]
		[Address(RVA = "0x2F1FDA0", Offset = "0x2F1EDA0", VA = "0x182F1FDA0")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DAB")]
		[Address(RVA = "0x2F204D0", Offset = "0x2F1F4D0", VA = "0x182F204D0")]
		public MaskTrigger()
		{
		}

		// Token: 0x04004170 RID: 16752
		[Token(Token = "0x4004170")]
		[FieldOffset(Offset = "0x20")]
		private bool _runningSequence;

		// Token: 0x04004171 RID: 16753
		[Token(Token = "0x4004171")]
		[FieldOffset(Offset = "0x21")]
		private bool _needsFinish;

		// Token: 0x04004172 RID: 16754
		[Token(Token = "0x4004172")]
		[FieldOffset(Offset = "0x24")]
		private int _animationHash;

		// Token: 0x04004173 RID: 16755
		[Token(Token = "0x4004173")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _alignTransform;

		// Token: 0x04004174 RID: 16756
		[Token(Token = "0x4004174")]
		[FieldOffset(Offset = "0x30")]
		private bool _hasStarted;

		// Token: 0x04004175 RID: 16757
		[Token(Token = "0x4004175")]
		[FieldOffset(Offset = "0x38")]
		private Animator _animator;
	}
}
