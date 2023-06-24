using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	[Serializable]
	public class WaitForState
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2D258C0", Offset = "0x2D23EC0", VA = "0x182D258C0")]
		private IEnumerable GetAnimationStates()
		{
			return null;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2D25970", Offset = "0x2D23F70", VA = "0x182D25970")]
		private IEnumerable GetAnimationLayers()
		{
			return null;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002D14 File Offset: 0x00000F14
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2D259C0", Offset = "0x2D23FC0", VA = "0x182D259C0")]
		private bool AnyLayerHasTag(Animator target, int tagHash, bool checkNextState)
		{
			return default(bool);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002D2C File Offset: 0x00000F2C
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2D25B10", Offset = "0x2D24110", VA = "0x182D25B10", Slot = "4")]
		public virtual bool Pass(Animator target, out bool error, bool checkNextState = false)
		{
			return default(bool);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002D44 File Offset: 0x00000F44
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2D25E20", Offset = "0x2D24420", VA = "0x182D25E20")]
		private static AnimatorStateInfo GetCurrentAnimatorStateInfo(Animator target, int layerIndex, bool checkNextState)
		{
			return default(AnimatorStateInfo);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1B19AA0", Offset = "0x1B180A0", VA = "0x181B19AA0")]
		public AnimationParameter GetAnimParam()
		{
			return default(AnimationParameter);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public WaitForState()
		{
		}

		// Token: 0x04001112 RID: 4370
		[Token(Token = "0x4001112")]
		[FieldOffset(Offset = "0x10")]
		[Delayed]
		[SerializeField]
		protected AnimationParameter _valueId;

		// Token: 0x04001113 RID: 4371
		[Token(Token = "0x4001113")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Delayed]
		protected AnimationParameter _layer;
	}
}
