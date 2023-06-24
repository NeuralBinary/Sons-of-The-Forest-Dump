using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PathCreation
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class GlobalDisplaySettings : ScriptableObject
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x282CDD0", Offset = "0x282B3D0", VA = "0x18282CDD0")]
		public GlobalDisplaySettings()
		{
		}

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x18")]
		[Header("Appearance")]
		public float anchorSize;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x1C")]
		public float controlSize;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Should the path still be drawn when behind objects in the scene?")]
		public bool visibleBehindObjects;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x21")]
		[Tooltip("Should the path be drawn even when the path object is not selected?")]
		public bool visibleWhenNotSelected;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x22")]
		[Tooltip("If true, control points will be hidden when the control point mode is set to automatic. Otherwise they will inactive, but still visible.")]
		public bool hideAutoControls;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x24")]
		public GlobalDisplaySettings.HandleType anchorShape;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x28")]
		public GlobalDisplaySettings.HandleType controlShape;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x2C")]
		[Header("Anchor Colours")]
		public Color anchor;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x3C")]
		public Color anchorHighlighted;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x4C")]
		public Color anchorSelected;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x5C")]
		[Header("Control Colours")]
		public Color control;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x6C")]
		public Color controlHighlighted;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x7C")]
		public Color controlSelected;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x8C")]
		public Color handleDisabled;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x9C")]
		public Color controlLine;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0xAC")]
		[Header("Bezier Path Colours")]
		public Color bezierPath;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0xBC")]
		public Color highlightedPath;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0xCC")]
		public Color bounds;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0xDC")]
		public Color segmentBounds;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0xEC")]
		[Header("Vertex Path Colours")]
		public Color vertexPath;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0xFC")]
		[Header("Normals")]
		public Color normals;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x10C")]
		[Range(0f, 1f)]
		public float normalsLength;

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		public enum HandleType
		{
			// Token: 0x04000035 RID: 53
			[Token(Token = "0x4000035")]
			Sphere,
			// Token: 0x04000036 RID: 54
			[Token(Token = "0x4000036")]
			Circle,
			// Token: 0x04000037 RID: 55
			[Token(Token = "0x4000037")]
			Square
		}
	}
}
