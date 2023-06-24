using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000154 RID: 340
	[Token(Token = "0x2000154")]
	[AddComponentMenu("Sons/Ai/Aura Influence")]
	public class AuraInfluence : MonoBehaviour
	{
		// Token: 0x06000B60 RID: 2912 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x784B80", Offset = "0x783180", VA = "0x180784B80")]
		public IReadOnlyList<StatAdjustmentsByClass> GetAdjustmentLists()
		{
			return null;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
		public void SetStrengthMult(float mult)
		{
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x2B94020", Offset = "0x2B92620", VA = "0x182B94020")]
		private void OnValidate()
		{
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x264B0B0", Offset = "0x26496B0", VA = "0x18264B0B0")]
		private void Awake()
		{
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x2B94070", Offset = "0x2B92670", VA = "0x182B94070")]
		private void OnEnable()
		{
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x2B941A0", Offset = "0x2B927A0", VA = "0x182B941A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00007080 File Offset: 0x00005280
		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x2B94340", Offset = "0x2B92940", VA = "0x182B94340")]
		public Vector3 Position()
		{
			return default(Vector3);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x2B943D0", Offset = "0x2B929D0", VA = "0x182B943D0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x2B94400", Offset = "0x2B92A00", VA = "0x182B94400")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x2B94430", Offset = "0x2B92A30", VA = "0x182B94430")]
		private void DrawGizmos(Color color)
		{
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00007098 File Offset: 0x00005298
		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x2B945C0", Offset = "0x2B92BC0", VA = "0x182B945C0")]
		public float GetRange()
		{
			return 0f;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x000070B0 File Offset: 0x000052B0
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x2B945E0", Offset = "0x2B92BE0", VA = "0x182B945E0")]
		public bool TryGetFactor(VailActor actor, float timeDelta, out float factor)
		{
			return default(bool);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x000070C8 File Offset: 0x000052C8
		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x2B94720", Offset = "0x2B92D20", VA = "0x182B94720")]
		public bool AffectsActor(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x000070E0 File Offset: 0x000052E0
		[Token(Token = "0x170000BE")]
		public bool HasAdjustments
		{
			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0x2B94810", Offset = "0x2B92E10", VA = "0x182B94810")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x1484950", Offset = "0x1482F50", VA = "0x181484950")]
		public MonoBehaviourStimuli GetStimuliSource()
		{
			return null;
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x2B94870", Offset = "0x2B92E70", VA = "0x182B94870")]
		public void Initialize(MonoBehaviourStimuli stimuliSource)
		{
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x2B948D0", Offset = "0x2B92ED0", VA = "0x182B948D0")]
		public AuraInfluence()
		{
		}

		// Token: 0x0400083C RID: 2108
		[Token(Token = "0x400083C")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Combat only avoids unseen nearby player affecting cannibals")]
		[SerializeField]
		private bool _combatOnly;

		// Token: 0x0400083D RID: 2109
		[Token(Token = "0x400083D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private EventDescription _value;

		// Token: 0x0400083E RID: 2110
		[Token(Token = "0x400083E")]
		[FieldOffset(Offset = "0x30")]
		private float _strengthMult;

		// Token: 0x0400083F RID: 2111
		[Token(Token = "0x400083F")]
		[FieldOffset(Offset = "0x38")]
		private Transform _transform;
	}
}
