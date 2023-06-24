using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[ExecuteAlways]
	public class OceanDepthCache : MonoBehaviour
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x1700004C")]
		public OceanDepthCache.OceanDepthCacheType Type
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return OceanDepthCache.OceanDepthCacheType.Realtime;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x1700004D")]
		public OceanDepthCache.OceanDepthCacheRefreshMode RefreshMode
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
			get
			{
				return OceanDepthCache.OceanDepthCacheRefreshMode.OnFirstUpdate;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x1700004E")]
		public Texture2D SavedCache
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000197 RID: 407 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x1700004F")]
		public RenderTexture CacheTexture
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x9E8710", Offset = "0x9E6D10", VA = "0x1809E8710")]
		private void Start()
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x9E8760", Offset = "0x9E6D60", VA = "0x1809E8760")]
		private RenderTexture MakeRT(bool depthStencilTarget)
		{
			return null;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x9E8960", Offset = "0x9E6F60", VA = "0x1809E8960")]
		private bool InitObjects()
		{
			return default(bool);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x9E9650", Offset = "0x9E7C50", VA = "0x1809E9650")]
		private void InitCacheQuad()
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x9E9CA0", Offset = "0x9E82A0", VA = "0x1809E9CA0")]
		private void Update()
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x9E9CC0", Offset = "0x9E82C0", VA = "0x1809E9CC0")]
		public void PopulateCache()
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x9EA530", Offset = "0x9E8B30", VA = "0x1809EA530")]
		public OceanDepthCache()
		{
		}

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Realtime = cache will be dynamic in accordance to refresh mode, Baked = cache will use the provided texture.")]
		private OceanDepthCache.OceanDepthCacheType _type;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("Ignored if baked. On Start = cache will populate in Start(), On Demand = call PopulateCache() manually via scripting.")]
		private OceanDepthCache.OceanDepthCacheRefreshMode _refreshMode;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Hides the depth cache camera, for cleanliness. Disable to make it visible in the Hierarchy.")]
		private bool _hideDepthCacheCam;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("The layers to render into the depth cache.")]
		public string[] _layerNames;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("The resolution of the cached depth - lower will be more efficient.")]
		public int _resolution;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("The 'near plane' for the depth cache camera (top down).")]
		[SerializeField]
		private float _cameraMaxTerrainHeight;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Will render into the cache every frame. Intended for debugging, will generate garbage.")]
		[SerializeField]
		private bool _forceAlwaysUpdateDebug;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Baked depth cache. Baking button available in play mode.")]
		[SerializeField]
		private Texture2D _savedCache;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Editor only: run validation checks on Start() to check for issues.")]
		[SerializeField]
		private bool _runValidationOnStart;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x58")]
		private RenderTexture _cacheTexture;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x60")]
		private GameObject _drawCacheQuad;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x68")]
		private Camera _camDepthCache;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x70")]
		private Material _copyDepthMaterial;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x78")]
		private bool _readyToRender;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x79")]
		private bool _renderDone;

		// Token: 0x02000044 RID: 68
		[Token(Token = "0x2000044")]
		public enum OceanDepthCacheType
		{
			// Token: 0x0400013D RID: 317
			[Token(Token = "0x400013D")]
			Realtime,
			// Token: 0x0400013E RID: 318
			[Token(Token = "0x400013E")]
			Baked
		}

		// Token: 0x02000045 RID: 69
		[Token(Token = "0x2000045")]
		public enum OceanDepthCacheRefreshMode
		{
			// Token: 0x04000140 RID: 320
			[Token(Token = "0x4000140")]
			OnFirstUpdate,
			// Token: 0x04000141 RID: 321
			[Token(Token = "0x4000141")]
			OnDemand
		}
	}
}
