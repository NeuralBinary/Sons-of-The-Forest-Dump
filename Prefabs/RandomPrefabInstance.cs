using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Prefabs
{
	// Token: 0x02000530 RID: 1328
	[Token(Token = "0x2000530")]
	public class RandomPrefabInstance : MonoBehaviour
	{
		// Token: 0x06002282 RID: 8834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002282")]
		[Address(RVA = "0x2D66860", Offset = "0x2D65860", VA = "0x182D66860", Slot = "4")]
		public virtual void OnDrawGizmos()
		{
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002283")]
		[Address(RVA = "0x2D66AF0", Offset = "0x2D65AF0", VA = "0x182D66AF0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x0000A0E0 File Offset: 0x000082E0
		[Token(Token = "0x6002284")]
		[Address(RVA = "0x2D66100", Offset = "0x2D65100", VA = "0x182D66100")]
		protected Bounds GetBounds()
		{
			return default(Bounds);
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002285")]
		[Address(RVA = "0x2D65960", Offset = "0x2D64960", VA = "0x182D65960")]
		private void Awake()
		{
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002286")]
		[Address(RVA = "0x2D66C20", Offset = "0x2D65C20", VA = "0x182D66C20")]
		private void RefreshRate()
		{
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002287")]
		[Address(RVA = "0x2D66CD0", Offset = "0x2D65CD0", VA = "0x182D66CD0")]
		private void Update()
		{
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002288")]
		[Address(RVA = "0x2D66850", Offset = "0x2D65850", VA = "0x182D66850")]
		private void OnDisable()
		{
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002289")]
		[Address(RVA = "0x2D65CF0", Offset = "0x2D64CF0", VA = "0x182D65CF0")]
		private void CleanupInstances()
		{
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600228A")]
		[Address(RVA = "0x2D66C50", Offset = "0x2D65C50", VA = "0x182D66C50")]
		private void RemoveInstanceTime(int i)
		{
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600228B")]
		[Address(RVA = "0x2D65F50", Offset = "0x2D64F50", VA = "0x182D65F50")]
		private void CreateInstance()
		{
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x0000A0F8 File Offset: 0x000082F8
		[Token(Token = "0x600228C")]
		[Address(RVA = "0x2D66550", Offset = "0x2D65550", VA = "0x182D66550")]
		private Vector3 GetRandomPoint()
		{
			return default(Vector3);
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600228D")]
		[Address(RVA = "0x2D661B0", Offset = "0x2D651B0", VA = "0x182D661B0")]
		private GameObject GetInstance()
		{
			return null;
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600228E")]
		[Address(RVA = "0x2D65BC0", Offset = "0x2D64BC0", VA = "0x182D65BC0")]
		private void CleanSourcePrefabs()
		{
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600228F")]
		[Address(RVA = "0x2D66690", Offset = "0x2D65690", VA = "0x182D66690")]
		private void InitializePools()
		{
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002290")]
		[Address(RVA = "0x2D66F80", Offset = "0x2D65F80", VA = "0x182D66F80")]
		public RandomPrefabInstance()
		{
		}

		// Token: 0x04001F4F RID: 8015
		[Token(Token = "0x4001F4F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Min(0f)]
		private float _rateMin;

		// Token: 0x04001F50 RID: 8016
		[Token(Token = "0x4001F50")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Min(0f)]
		private float _rateMax;

		// Token: 0x04001F51 RID: 8017
		[Token(Token = "0x4001F51")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _lifeTime;

		// Token: 0x04001F52 RID: 8018
		[Token(Token = "0x4001F52")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _activeDistance;

		// Token: 0x04001F53 RID: 8019
		[Token(Token = "0x4001F53")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _sourcePrefabs;

		// Token: 0x04001F54 RID: 8020
		[Token(Token = "0x4001F54")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BoxCollider _instanceVolume;

		// Token: 0x04001F55 RID: 8021
		[Token(Token = "0x4001F55")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Bounds _bounds;

		// Token: 0x04001F56 RID: 8022
		[Token(Token = "0x4001F56")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		internal Color _gizmoColor;

		// Token: 0x04001F57 RID: 8023
		[Token(Token = "0x4001F57")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<GameObject, Queue<GameObject>> _pools;

		// Token: 0x04001F58 RID: 8024
		[Token(Token = "0x4001F58")]
		[FieldOffset(Offset = "0x70")]
		private List<GameObject> _liveInstances;

		// Token: 0x04001F59 RID: 8025
		[Token(Token = "0x4001F59")]
		[FieldOffset(Offset = "0x78")]
		private List<GameObject> _liveInstanceKeys;

		// Token: 0x04001F5A RID: 8026
		[Token(Token = "0x4001F5A")]
		[FieldOffset(Offset = "0x80")]
		private List<float> _liveInstanceTimes;

		// Token: 0x04001F5B RID: 8027
		[Token(Token = "0x4001F5B")]
		[FieldOffset(Offset = "0x88")]
		private float _lastInstanceCheckTime;

		// Token: 0x04001F5C RID: 8028
		[Token(Token = "0x4001F5C")]
		[FieldOffset(Offset = "0x8C")]
		private float _rate;
	}
}
