using System;
using Endnight.Animation;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[AddComponentMenu("Sons/Characters/SimpleMoverActor")]
	public class SimpleMoverActor : MonoBehaviour, IAnimatorMoveProxyReceiver
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2AECD90", Offset = "0x2AEB390", VA = "0x182AECD90")]
		private void Awake()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2AECE40", Offset = "0x2AEB440", VA = "0x182AECE40")]
		private void Start()
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2AECF80", Offset = "0x2AEB580", VA = "0x182AECF80")]
		private void OnValidate()
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2AED1C0", Offset = "0x2AEB7C0", VA = "0x182AED1C0")]
		public void StartOnPath(SurfaceMoverPath path)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2AED3B0", Offset = "0x2AEB9B0", VA = "0x182AED3B0", Slot = "4")]
		public void OnAnimatorMove()
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2AED440", Offset = "0x2AEBA40", VA = "0x182AED440")]
		private void Update()
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2AED5A0", Offset = "0x2AEBBA0", VA = "0x182AED5A0")]
		public SimpleMoverActor()
		{
		}

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SurfaceMover _surfaceMover;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _animMoveSpeed;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 _animatorMoveDelta;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x40")]
		private Transform _transform;
	}
}
