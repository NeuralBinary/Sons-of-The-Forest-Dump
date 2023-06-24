using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Atmosphere
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	public class FreezeWater : MonoBehaviour, ISeasonsReceiver
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x17000012")]
		public bool IsFrozen
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x179C600", Offset = "0x179AC00", VA = "0x18179C600")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x17000013")]
		public bool WaterInteractionsBlocked
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x9ABDB0", Offset = "0x9AA3B0", VA = "0x1809ABDB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2D40650", Offset = "0x2D3EC50", VA = "0x182D40650")]
		private void Update()
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2D406F0", Offset = "0x2D3ECF0", VA = "0x182D406F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2D40700", Offset = "0x2D3ED00", VA = "0x182D40700")]
		private void OnValidate()
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2D40B80", Offset = "0x2D3F180", VA = "0x182D40B80")]
		private void Start()
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2D40C80", Offset = "0x2D3F280", VA = "0x182D40C80")]
		private void Initialize()
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015B")]
		private void SetupComponent<T>(ref T target) where T : Component
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2D41270", Offset = "0x2D3F870", VA = "0x182D41270")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2D412C0", Offset = "0x2D3F8C0", VA = "0x182D412C0", Slot = "4")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2D412F0", Offset = "0x2D3F8F0", VA = "0x182D412F0")]
		private void FreezeWithCheck(bool freeze)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2D414A0", Offset = "0x2D3FAA0", VA = "0x182D414A0")]
		private void Freeze(bool freeze)
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2D41E30", Offset = "0x2D40430", VA = "0x182D41E30")]
		private bool IsCloseToActiveWorldLocation()
		{
			return default(bool);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2D41F80", Offset = "0x2D40580", VA = "0x182D41F80")]
		private void ToggleFreeze()
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2D41FB0", Offset = "0x2D405B0", VA = "0x182D41FB0")]
		public void Setup(MeshFilter waterMeshFilter, MeshRenderer waterMeshRenderer, MeshCollider baseTrigger, bool forceFrozen, bool neverFreeze, bool waterInteractionsBlocked)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2D420F0", Offset = "0x2D406F0", VA = "0x182D420F0")]
		public bool SetNavMeshCut(NavmeshCut navmeshCut)
		{
			return default(bool);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2D42210", Offset = "0x2D40810", VA = "0x182D42210")]
		public FreezeWater()
		{
		}

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _waterMeshFilter;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_waterRenderer")]
		private MeshRenderer _waterMeshRenderer;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Collider _waterTrigger;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private NavmeshCut _waterNavMeshCut;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _waterStimuliRoot;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private MeshCollider _frozenMeshCollider;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<MeshCollider> _frozenMeshColliderExtra;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x58")]
		[FormerlySerializedAs("_iceMaterial")]
		[SerializeField]
		private Material _frozenMaterial;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AreaEmitter _frozenEmitter;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[FormerlySerializedAs("_iceMeshRenderer")]
		private MeshRenderer _frozenMeshRenderer;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[FormerlySerializedAs("_iceMeshFilter")]
		private MeshFilter _frozenMeshFilter;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<GameObject> _extras;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _waterInteractionsBlocked;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x81")]
		[SerializeField]
		private bool _forceFrozen;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x82")]
		[SerializeField]
		private bool _neverFreeze;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _freezeChangeMinDistance;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x88")]
		private bool _isFrozen;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x89")]
		private bool _hasPendingFreezeValue;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x8A")]
		private bool _pendingFreezeValue;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		private const int FreezeCheckFrameInterval = 10;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x8B")]
		private bool _initialized;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x8C")]
		private int _freezeCheckFrameOffset;
	}
}
