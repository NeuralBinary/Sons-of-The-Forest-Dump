using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Animation.Mae;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[AddComponentMenu("Sons/Characters/PlayRandomAnimationState")]
	public class PlayRandomAnimationState : MonoBehaviour
	{
		// Token: 0x06000066 RID: 102 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2AECB30", Offset = "0x2AEB130", VA = "0x182AECB30")]
		private IEnumerable AnimStateParameters()
		{
			return null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2AECB80", Offset = "0x2AEB180", VA = "0x182AECB80")]
		private void OnValidate()
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2AECC70", Offset = "0x2AEB270", VA = "0x182AECC70")]
		private void OnEnable()
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x6C2910", Offset = "0x6C0F10", VA = "0x1806C2910")]
		public PlayRandomAnimationState()
		{
		}

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationParameter[] _playStates;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _keepAnimatorOnDisable;
	}
}
