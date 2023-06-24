using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/Internal/Draw Call")]
	public class UIDrawCall : MonoBehaviour
	{
		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000109")]
		[Obsolete("Use UIDrawCall.activeList")]
		public static BetterList<UIDrawCall> list
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x26940C0", Offset = "0x26926C0", VA = "0x1826940C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700010A")]
		public static BetterList<UIDrawCall> activeList
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x2694110", Offset = "0x2692710", VA = "0x182694110")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700010B")]
		public static BetterList<UIDrawCall> inactiveList
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x2694160", Offset = "0x2692760", VA = "0x182694160")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00004038 File Offset: 0x00002238
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010C")]
		public int renderQueue
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0xAFF440", Offset = "0xAFDA40", VA = "0x180AFF440")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x26941B0", Offset = "0x26927B0", VA = "0x1826941B0")]
			set
			{
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00004050 File Offset: 0x00002250
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010D")]
		public int sortingOrder
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x26942B0", Offset = "0x26928B0", VA = "0x1826942B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x26943D0", Offset = "0x26929D0", VA = "0x1826943D0")]
			set
			{
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x1700010E")]
		public int finalRenderQueue
		{
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x2694510", Offset = "0x2692B10", VA = "0x182694510")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700010F")]
		public Transform cachedTransform
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x2694640", Offset = "0x2692C40", VA = "0x182694640")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000110")]
		public Material baseMaterial
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x26947A0", Offset = "0x2692DA0", VA = "0x1826947A0")]
			set
			{
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000111")]
		public Material dynamicMaterial
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000112")]
		public Texture mainTexture
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x2694910", Offset = "0x2692F10", VA = "0x182694910")]
			set
			{
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000113")]
		public Shader shader
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x2694A50", Offset = "0x2693050", VA = "0x182694A50")]
			set
			{
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x17000114")]
		public int triangles
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x2694BD0", Offset = "0x26931D0", VA = "0x182694BD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x17000115")]
		public bool isClipped
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x2694CB0", Offset = "0x26932B0", VA = "0x182694CB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2694CC0", Offset = "0x26932C0", VA = "0x182694CC0")]
		private void CreateMaterial()
		{
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2695880", Offset = "0x2693E80", VA = "0x182695880")]
		private Material RebuildMaterial()
		{
			return null;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2695B60", Offset = "0x2694160", VA = "0x182695B60")]
		private void UpdateMaterials()
		{
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2695E20", Offset = "0x2694420", VA = "0x182695E20")]
		public void UpdateGeometry(int widgetCount)
		{
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2696EB0", Offset = "0x26954B0", VA = "0x182696EB0")]
		private int[] GenerateCachedIndexBuffer(int vertexCount, int indexCount)
		{
			return null;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x26971D0", Offset = "0x26957D0", VA = "0x1826971D0")]
		private void OnWillRenderObject()
		{
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2697A50", Offset = "0x2696050", VA = "0x182697A50")]
		private void SetClipping(int index, Vector4 cr, Vector2 soft, float angle)
		{
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2697D10", Offset = "0x2696310", VA = "0x182697D10")]
		private void Awake()
		{
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2698230", Offset = "0x2696830", VA = "0x182698230")]
		private void OnEnable()
		{
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2698240", Offset = "0x2696840", VA = "0x182698240")]
		private void OnDisable()
		{
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x26985D0", Offset = "0x2696BD0", VA = "0x1826985D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x2698680", Offset = "0x2696C80", VA = "0x182698680")]
		public static UIDrawCall Create(UIPanel panel, Material mat, Texture tex, Shader shader)
		{
			return null;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2698710", Offset = "0x2696D10", VA = "0x182698710")]
		private static UIDrawCall Create(string name, UIPanel pan, Material mat, Texture tex, Shader shader)
		{
			return null;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2698A90", Offset = "0x2697090", VA = "0x182698A90")]
		private static UIDrawCall Create(string name)
		{
			return null;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2698D80", Offset = "0x2697380", VA = "0x182698D80")]
		public static void ClearAll()
		{
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2699000", Offset = "0x2697600", VA = "0x182699000")]
		public static void ReleaseAll()
		{
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2699050", Offset = "0x2697650", VA = "0x182699050")]
		public static void ReleaseInactive()
		{
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2699250", Offset = "0x2697850", VA = "0x182699250")]
		public static int Count(UIPanel panel)
		{
			return 0;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2699460", Offset = "0x2697A60", VA = "0x182699460")]
		public static void Destroy(UIDrawCall dc)
		{
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x2699780", Offset = "0x2697D80", VA = "0x182699780")]
		public UIDrawCall()
		{
		}

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x0")]
		private static BetterList<UIDrawCall> mActiveList;

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x8")]
		private static BetterList<UIDrawCall> mInactiveList;

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[NonSerialized]
		public int widgetCount;

		// Token: 0x0400035A RID: 858
		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[NonSerialized]
		public int depthStart;

		// Token: 0x0400035B RID: 859
		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[NonSerialized]
		public int depthEnd;

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[NonSerialized]
		public UIPanel manager;

		// Token: 0x0400035D RID: 861
		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[NonSerialized]
		public UIPanel panel;

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[NonSerialized]
		public Texture2D clipTexture;

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[NonSerialized]
		public bool alwaysOnScreen;

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[NonSerialized]
		public BetterList<Vector3> verts;

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		[NonSerialized]
		public BetterList<Vector3> norms;

		// Token: 0x04000362 RID: 866
		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[NonSerialized]
		public BetterList<Vector4> tans;

		// Token: 0x04000363 RID: 867
		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[NonSerialized]
		public BetterList<Vector2> uvs;

		// Token: 0x04000364 RID: 868
		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x70")]
		[HideInInspector]
		[NonSerialized]
		public BetterList<Color32> cols;

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x78")]
		private Material mMaterial;

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x80")]
		private Texture mTexture;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x88")]
		private Shader mShader;

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x90")]
		private int mClipCount;

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x98")]
		private Transform mTrans;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0xA0")]
		private Mesh mMesh;

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0xA8")]
		private MeshFilter mFilter;

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0xB0")]
		private MeshRenderer mRenderer;

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0xB8")]
		private Material mDynamicMat;

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0xC0")]
		private int[] mIndices;

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0xC8")]
		private bool mRebuildMat;

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0xC9")]
		private bool mLegacyShader;

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0xCC")]
		private int mRenderQueue;

		// Token: 0x04000372 RID: 882
		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0xD0")]
		private int mTriangles;

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0xD4")]
		[NonSerialized]
		public bool isDirty;

		// Token: 0x04000374 RID: 884
		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0xD5")]
		[NonSerialized]
		private bool mTextureClip;

		// Token: 0x04000375 RID: 885
		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0xD8")]
		public UIDrawCall.OnRenderCallback onRender;

		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		private const int maxIndexBufferCache = 10;

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x10")]
		private static List<int[]> mCache;

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x18")]
		private static int[] ClipRange;

		// Token: 0x04000379 RID: 889
		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x20")]
		private static int[] ClipArgs;

		// Token: 0x02000082 RID: 130
		[Token(Token = "0x2000082")]
		public enum Clipping
		{
			// Token: 0x0400037B RID: 891
			[Token(Token = "0x400037B")]
			None,
			// Token: 0x0400037C RID: 892
			[Token(Token = "0x400037C")]
			TextureMask,
			// Token: 0x0400037D RID: 893
			[Token(Token = "0x400037D")]
			SoftClip = 3,
			// Token: 0x0400037E RID: 894
			[Token(Token = "0x400037E")]
			ConstrainButDontClip
		}

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x06000517 RID: 1303
		[Token(Token = "0x2000083")]
		public delegate void OnRenderCallback(Material mat);
	}
}
