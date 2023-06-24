using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	[ExecuteAlways]
	public class OceanDebugGUI : MonoBehaviour
	{
		// Token: 0x06000074 RID: 116 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x9CF5B0", Offset = "0x9CDBB0", VA = "0x1809CF5B0")]
		public static bool OverGUI(Vector2 screenPosition)
		{
			return default(bool);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x9CF610", Offset = "0x9CDC10", VA = "0x1809CF610")]
		private void Update()
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x9CF880", Offset = "0x9CDE80", VA = "0x1809CF880")]
		private void OnGUI()
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x9D0DB0", Offset = "0x9CF3B0", VA = "0x1809D0DB0")]
		private void DrawShapeTargets()
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x9D1260", Offset = "0x9CF860", VA = "0x1809D1260")]
		private void DrawSims()
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		private static void DrawSim<SimType>(LodDataMgr lodData, ref bool doDraw, ref float offset) where SimType : LodDataMgr
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x9D1630", Offset = "0x9CFC30", VA = "0x1809D1630")]
		private void ToggleGUI()
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x9D1640", Offset = "0x9CFC40", VA = "0x1809D1640")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitStatics()
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x9D1720", Offset = "0x9CFD20", VA = "0x1809D1720")]
		public OceanDebugGUI()
		{
		}

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x20")]
		public bool _showOceanData;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x21")]
		public bool _guiVisible;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x22")]
		[SerializeField]
		[Header("Lod Datas")]
		private bool _drawAnimWaves;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x23")]
		[SerializeField]
		private bool _drawDynWaves;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _drawFoam;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x25")]
		[SerializeField]
		private bool _drawFlow;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x26")]
		[SerializeField]
		private bool _drawShadow;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x27")]
		[SerializeField]
		private bool _drawSeaFloorDepth;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _drawClipSurface;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float _leftPanelWidth;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x4")]
		private static readonly float _bottomPanelHeight;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Color _guiColor;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x30")]
		private ShapeGerstnerBatched[] _gerstners;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Dictionary<Type, string> s_simNames;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x20")]
		private static Material s_textureArrayMaterial;
	}
}
