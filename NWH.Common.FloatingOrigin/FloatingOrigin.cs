using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace NWH.Common.FloatingOrigin
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class FloatingOrigin : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		public Vector3 TotalOffset
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x26ECB30", Offset = "0x26EB130", VA = "0x1826ECB30")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x26ECB50", Offset = "0x26EB150", VA = "0x1826ECB50")]
		private void Awake()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000005")]
		private List<T> FindObjects<T>() where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x26ECC90", Offset = "0x26EB290", VA = "0x1826ECC90")]
		private void BeforeJump()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x26ECE40", Offset = "0x26EB440", VA = "0x1826ECE40")]
		private void AfterJump()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x26ED050", Offset = "0x26EB650", VA = "0x1826ED050")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x26ED300", Offset = "0x26EB900", VA = "0x1826ED300")]
		private void Jump()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x26ED9B0", Offset = "0x26EBFB0", VA = "0x1826ED9B0")]
		public FloatingOrigin()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		public static FloatingOrigin Instance;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		public float distanceThreshold;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent OnBeforeJump;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent OnAfterJump;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _totalOffset;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x48")]
		private Camera _cameraMain;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x50")]
		private Transform _cameraTransform;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 _cameraPosition;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x68")]
		private ParticleSystem.Particle[] _particles;
	}
}
