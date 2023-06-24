using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Utilities
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[AddComponentMenu("Sons/Utilities/DestroyAfter")]
	public class DestroyAfter : MonoBehaviour
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x315E950", Offset = "0x315CF50", VA = "0x18315E950")]
		private void Start()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x315E960", Offset = "0x315CF60", VA = "0x18315E960")]
		private void OnEnable()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x315E970", Offset = "0x315CF70", VA = "0x18315E970")]
		private void OnDisable()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x315EA10", Offset = "0x315D010", VA = "0x18315EA10")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x623BB0", Offset = "0x6221B0", VA = "0x180623BB0")]
		public void SetDestroyTime(float value)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
		public void SetDestroyDistance(float value)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2084CC0", Offset = "0x20832C0", VA = "0x182084CC0")]
		public void SetUseUnscaledTime(bool value)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x315EA90", Offset = "0x315D090", VA = "0x18315EA90")]
		public void SetPool(string poolName)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x315EAF0", Offset = "0x315D0F0", VA = "0x18315EAF0")]
		private void InvokeDestroy()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x315EDA0", Offset = "0x315D3A0", VA = "0x18315EDA0")]
		private IEnumerator DestroyUnscaledTimeRoutine()
		{
			return null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x315EE30", Offset = "0x315D430", VA = "0x18315EE30")]
		private void DoDestroy()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x315EE40", Offset = "0x315D440", VA = "0x18315EE40")]
		private void DoDestroyInternal(bool skipDistanceCheck = false)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x315F3B0", Offset = "0x315D9B0", VA = "0x18315F3B0")]
		public DestroyAfter()
		{
		}

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _randomizeDelayTime;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector2 _destroyTimeRange;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x2C")]
		[FormerlySerializedAs("destroyTime")]
		[SerializeField]
		private float _destroyTime;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("destroyDistance")]
		private float _destroyDistance;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[FormerlySerializedAs("useUnscaledTime")]
		private bool _useUnscaledTime;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x35")]
		[SerializeField]
		private bool _ignoreIfChildOfAttachedBoltEntity;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x36")]
		[SerializeField]
		private bool _despawnFromPool;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x37")]
		[SerializeField]
		private bool _destroyOnDisable;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _poolName;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x40")]
		private bool _wasDisabled;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x0")]
		private static System.Random _random;
	}
}
