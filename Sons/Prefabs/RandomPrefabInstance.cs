using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Prefabs
{
	// Token: 0x02000538 RID: 1336
	[Token(Token = "0x2000538")]
	public class RandomPrefabInstance : MonoBehaviour
	{
		// Token: 0x0600236F RID: 9071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236F")]
		[Address(RVA = "0x334DD70", Offset = "0x334C370", VA = "0x18334DD70", Slot = "4")]
		public virtual void OnDrawGizmos()
		{
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002370")]
		[Address(RVA = "0x334E1B0", Offset = "0x334C7B0", VA = "0x18334E1B0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x0000A728 File Offset: 0x00008928
		[Token(Token = "0x6002371")]
		[Address(RVA = "0x334E410", Offset = "0x334CA10", VA = "0x18334E410")]
		protected Bounds GetBounds()
		{
			return default(Bounds);
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002372")]
		[Address(RVA = "0x334E560", Offset = "0x334CB60", VA = "0x18334E560")]
		private void Awake()
		{
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002373")]
		[Address(RVA = "0x334E760", Offset = "0x334CD60", VA = "0x18334E760")]
		private void RefreshRate()
		{
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002374")]
		[Address(RVA = "0x334E790", Offset = "0x334CD90", VA = "0x18334E790")]
		private void Update()
		{
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002375")]
		[Address(RVA = "0x334E9A0", Offset = "0x334CFA0", VA = "0x18334E9A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002376")]
		[Address(RVA = "0x334E9B0", Offset = "0x334CFB0", VA = "0x18334E9B0")]
		private void CleanupInstances()
		{
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002377")]
		[Address(RVA = "0x334EC90", Offset = "0x334D290", VA = "0x18334EC90")]
		private void RemoveInstanceTime(int i)
		{
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002378")]
		[Address(RVA = "0x334ED40", Offset = "0x334D340", VA = "0x18334ED40")]
		private void CreateInstance()
		{
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x0000A740 File Offset: 0x00008940
		[Token(Token = "0x6002379")]
		[Address(RVA = "0x334EF50", Offset = "0x334D550", VA = "0x18334EF50")]
		private Vector3 GetRandomPoint()
		{
			return default(Vector3);
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600237A")]
		[Address(RVA = "0x334F010", Offset = "0x334D610", VA = "0x18334F010")]
		private GameObject GetInstance()
		{
			return null;
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237B")]
		[Address(RVA = "0x334F5D0", Offset = "0x334DBD0", VA = "0x18334F5D0")]
		private void CleanSourcePrefabs()
		{
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237C")]
		[Address(RVA = "0x334F7C0", Offset = "0x334DDC0", VA = "0x18334F7C0")]
		private void InitializePools()
		{
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237D")]
		[Address(RVA = "0x334FA90", Offset = "0x334E090", VA = "0x18334FA90")]
		public RandomPrefabInstance()
		{
		}

		// Token: 0x04002003 RID: 8195
		[Token(Token = "0x4002003")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Min(0f)]
		private float _rateMin;

		// Token: 0x04002004 RID: 8196
		[Token(Token = "0x4002004")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Min(0f)]
		private float _rateMax;

		// Token: 0x04002005 RID: 8197
		[Token(Token = "0x4002005")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _lifeTime;

		// Token: 0x04002006 RID: 8198
		[Token(Token = "0x4002006")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _activeDistance;

		// Token: 0x04002007 RID: 8199
		[Token(Token = "0x4002007")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _sourcePrefabs;

		// Token: 0x04002008 RID: 8200
		[Token(Token = "0x4002008")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BoxCollider _instanceVolume;

		// Token: 0x04002009 RID: 8201
		[Token(Token = "0x4002009")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Bounds _bounds;

		// Token: 0x0400200A RID: 8202
		[Token(Token = "0x400200A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		internal Color _gizmoColor;

		// Token: 0x0400200B RID: 8203
		[Token(Token = "0x400200B")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<GameObject, Queue<GameObject>> _pools;

		// Token: 0x0400200C RID: 8204
		[Token(Token = "0x400200C")]
		[FieldOffset(Offset = "0x70")]
		private List<GameObject> _liveInstances;

		// Token: 0x0400200D RID: 8205
		[Token(Token = "0x400200D")]
		[FieldOffset(Offset = "0x78")]
		private List<GameObject> _liveInstanceKeys;

		// Token: 0x0400200E RID: 8206
		[Token(Token = "0x400200E")]
		[FieldOffset(Offset = "0x80")]
		private List<float> _liveInstanceTimes;

		// Token: 0x0400200F RID: 8207
		[Token(Token = "0x400200F")]
		[FieldOffset(Offset = "0x88")]
		private float _lastInstanceCheckTime;

		// Token: 0x04002010 RID: 8208
		[Token(Token = "0x4002010")]
		[FieldOffset(Offset = "0x8C")]
		private float _rate;
	}
}
