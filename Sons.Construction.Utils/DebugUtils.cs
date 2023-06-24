using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Utils
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[ExecuteInEditMode]
	public class DebugUtils : MonoBehaviour
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2DBB410", Offset = "0x2DB9A10", VA = "0x182DBB410")]
		private void Awake()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2DBB4A0", Offset = "0x2DB9AA0", VA = "0x182DBB4A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2DBB630", Offset = "0x2DB9C30", VA = "0x182DBB630")]
		[Conditional("UNITY_EDITOR")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2DBB8A0", Offset = "0x2DB9EA0", VA = "0x182DBB8A0")]
		[Conditional("UNITY_EDITOR")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawLine(Vector3 from, Vector3 to, Color color, float thickness = 0f, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawDottedLine(Vector3 from, Vector3 to, Color color, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawLineWithArrow(Vector3 from, Vector3 to, Color color, float thickness = 0f, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawDottedLineWithArrow(Vector3 from, Vector3 to, Color color, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2DBBB40", Offset = "0x2DBA140", VA = "0x182DBBB40")]
		[Conditional("UNITY_EDITOR")]
		private static void DrawLineInternal(Vector3 from, Vector3 to, Color color, float thickness = 0f, bool dotted = false, bool arrowCap = false, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawLineAndLabel(Vector3 from, Vector3 to, string label, Color color, float thickness = 0f, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawLineAndLabelWithArrow(Vector3 from, Vector3 to, string label, Color color, float thickness = 0f, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2DBBD10", Offset = "0x2DBA310", VA = "0x182DBBD10")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawLineAndLabel(Vector3 from, Vector3 to, float minDist, string label, Color color, float thickness = 0f, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawDottedLineAndLabel(Vector3 from, Vector3 to, string label, Color color, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawDottedLineAndLabelWithArrow(Vector3 from, Vector3 to, string label, Color color, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2DBBD10", Offset = "0x2DBA310", VA = "0x182DBBD10")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawDottedLineAndLabel(Vector3 from, Vector3 to, float minDist, string label, Color color, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2DBBD50", Offset = "0x2DBA350", VA = "0x182DBBD50")]
		[Conditional("UNITY_EDITOR")]
		private static void DrawLineAndLabelInternal(Vector3 from, Vector3 to, string label, Color color, float thickness = 0f, bool dotted = false, bool arrowCap = false, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawLabel(Vector3 pos, string label, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2DBBF60", Offset = "0x2DBA560", VA = "0x182DBBF60")]
		[Conditional("UNITY_EDITOR")]
		private static void DrawLabelInternal(Vector3 pos, string label, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawCircle(Vector3 center, Vector3 normal, float radius, Color color, float thickness = 1f, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawSolidCircle(Vector3 center, Vector3 normal, float radius, Color color, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2DBC120", Offset = "0x2DBA720", VA = "0x182DBC120")]
		[Conditional("UNITY_EDITOR")]
		private static void DrawCircleInternal(Vector3 center, Vector3 normal, float radius, Color color, float thickness = 1f, bool solid = false, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawSquare(Vector3 center, Vector3 size, Quaternion orientation, Color color, Color outlineColor, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2DBC2F0", Offset = "0x2DBA8F0", VA = "0x182DBC2F0")]
		[Conditional("UNITY_EDITOR")]
		private static void DrawSquareInternal(Vector3 center, Vector3 size, Quaternion orientation, Color color, Color outlineColor, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawBox(Vector3 center, Vector3 size, Quaternion orientation, Color color, float thickness = 0f, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2DBC5B0", Offset = "0x2DBABB0", VA = "0x182DBC5B0")]
		[Conditional("UNITY_EDITOR")]
		private static void DrawBoxInternal(Vector3 center, Vector3 size, Quaternion orientation, Color color, float thickness = 0f, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawSphere(Vector3 center, float radius, Color color, float thickness = 0f, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawSolidSphere(Vector3 center, float radius, Color color, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2DBC860", Offset = "0x2DBAE60", VA = "0x182DBC860")]
		[Conditional("UNITY_EDITOR")]
		private static void DrawSphereInternal(Vector3 center, float radius, Color color, float thickness = 0f, bool solid = false, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawPlane(Vector3 center, Vector3 normal, float radius, Color color, float thickness = 1f, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawPlane(Vector3 center, Plane plane, float radius, Color color, float thickness = 1f, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawSolidPlane(Vector3 center, Vector3 normal, float radius, Color color, float thickness = 1f, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawSolidPlane(Vector3 center, Plane plane, float radius, Color color, float thickness = 1f, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2DBCA20", Offset = "0x2DBB020", VA = "0x182DBCA20")]
		[Conditional("UNITY_EDITOR")]
		private static void DrawPlaneInternal(Vector3 center, Vector3 normal, float radius, Color color, float thickness = 1f, bool solid = false, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2DBCBF0", Offset = "0x2DBB1F0", VA = "0x182DBCBF0")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawCylinder(Vector3 from, Vector3 to, Vector3 up, Color color, float radius, int edges, float thickness = 0f, float duration = 0f, int id = -1)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2DBCE10", Offset = "0x2DBB410", VA = "0x182DBCE10")]
		[Conditional("UNITY_EDITOR")]
		public static void SetColorById(int id, Color color)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2DBD040", Offset = "0x2DBB640", VA = "0x182DBD040")]
		[Conditional("UNITY_EDITOR")]
		public static void RemoveById(int id)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2DBD290", Offset = "0x2DBB890", VA = "0x182DBD290")]
		[Conditional("UNITY_EDITOR")]
		private static void EnsureInstance()
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2DBD4B0", Offset = "0x2DBBAB0", VA = "0x182DBD4B0")]
		public DebugUtils()
		{
		}

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x20")]
		private List<DebugUtils.DebugData> _frameDebugData;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x28")]
		private List<DebugUtils.DebugData> _frameDebugData2;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<DebugUtils.DebugData> _persistentDebugData;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x0")]
		private static DebugUtils _instance;

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		private abstract class DebugData
		{
			// Token: 0x06000047 RID: 71
			[Token(Token = "0x6000047")]
			public abstract void Draw();

			// Token: 0x06000048 RID: 72
			[Token(Token = "0x6000048")]
			public abstract void Dispose();

			// Token: 0x06000049 RID: 73 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			protected DebugData()
			{
			}

			// Token: 0x0400002F RID: 47
			[Token(Token = "0x400002F")]
			[FieldOffset(Offset = "0x10")]
			public int Id;

			// Token: 0x04000030 RID: 48
			[Token(Token = "0x4000030")]
			[FieldOffset(Offset = "0x14")]
			public float EndTime;

			// Token: 0x04000031 RID: 49
			[Token(Token = "0x4000031")]
			[FieldOffset(Offset = "0x18")]
			public Color Color;
		}

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		private class LineData : DebugUtils.DebugData
		{
			// Token: 0x0600004A RID: 74 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
			public override void Draw()
			{
			}

			// Token: 0x0600004B RID: 75 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2DBD680", Offset = "0x2DBBC80", VA = "0x182DBD680", Slot = "5")]
			public override void Dispose()
			{
			}

			// Token: 0x0600004C RID: 76 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public LineData()
			{
			}

			// Token: 0x04000032 RID: 50
			[Token(Token = "0x4000032")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 From;

			// Token: 0x04000033 RID: 51
			[Token(Token = "0x4000033")]
			[FieldOffset(Offset = "0x34")]
			public Vector3 To;

			// Token: 0x04000034 RID: 52
			[Token(Token = "0x4000034")]
			[FieldOffset(Offset = "0x40")]
			public float Thickness;

			// Token: 0x04000035 RID: 53
			[Token(Token = "0x4000035")]
			[FieldOffset(Offset = "0x44")]
			public bool Dotted;

			// Token: 0x04000036 RID: 54
			[Token(Token = "0x4000036")]
			[FieldOffset(Offset = "0x45")]
			public bool ArrowCap;
		}

		// Token: 0x0200000A RID: 10
		[Token(Token = "0x200000A")]
		private class LineAndLabelData : DebugUtils.LineData
		{
			// Token: 0x0600004D RID: 77 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
			public override void Draw()
			{
			}

			// Token: 0x0600004E RID: 78 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2DBD6E0", Offset = "0x2DBBCE0", VA = "0x182DBD6E0", Slot = "5")]
			public override void Dispose()
			{
			}

			// Token: 0x0600004F RID: 79 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public LineAndLabelData()
			{
			}

			// Token: 0x04000037 RID: 55
			[Token(Token = "0x4000037")]
			[FieldOffset(Offset = "0x48")]
			public string Label;
		}

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		private class LabelData : DebugUtils.DebugData
		{
			// Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
			public override void Draw()
			{
			}

			// Token: 0x06000051 RID: 81 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2DBD740", Offset = "0x2DBBD40", VA = "0x182DBD740", Slot = "5")]
			public override void Dispose()
			{
			}

			// Token: 0x06000052 RID: 82 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public LabelData()
			{
			}

			// Token: 0x04000038 RID: 56
			[Token(Token = "0x4000038")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 From;

			// Token: 0x04000039 RID: 57
			[Token(Token = "0x4000039")]
			[FieldOffset(Offset = "0x38")]
			public string Label;
		}

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		private class PlaneData : DebugUtils.DebugData
		{
			// Token: 0x06000053 RID: 83 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
			public override void Draw()
			{
			}

			// Token: 0x06000054 RID: 84 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2DBD7A0", Offset = "0x2DBBDA0", VA = "0x182DBD7A0", Slot = "5")]
			public override void Dispose()
			{
			}

			// Token: 0x06000055 RID: 85 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public PlaneData()
			{
			}

			// Token: 0x0400003A RID: 58
			[Token(Token = "0x400003A")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 Center;

			// Token: 0x0400003B RID: 59
			[Token(Token = "0x400003B")]
			[FieldOffset(Offset = "0x34")]
			public Vector3 Normal;

			// Token: 0x0400003C RID: 60
			[Token(Token = "0x400003C")]
			[FieldOffset(Offset = "0x40")]
			public float Radius;

			// Token: 0x0400003D RID: 61
			[Token(Token = "0x400003D")]
			[FieldOffset(Offset = "0x44")]
			public bool Solid;

			// Token: 0x0400003E RID: 62
			[Token(Token = "0x400003E")]
			[FieldOffset(Offset = "0x48")]
			public float Thickness;
		}

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x200000D")]
		private class CircleData : DebugUtils.DebugData
		{
			// Token: 0x06000056 RID: 86 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
			public override void Draw()
			{
			}

			// Token: 0x06000057 RID: 87 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2DBD800", Offset = "0x2DBBE00", VA = "0x182DBD800", Slot = "5")]
			public override void Dispose()
			{
			}

			// Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CircleData()
			{
			}

			// Token: 0x0400003F RID: 63
			[Token(Token = "0x400003F")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 Center;

			// Token: 0x04000040 RID: 64
			[Token(Token = "0x4000040")]
			[FieldOffset(Offset = "0x34")]
			public Vector3 Normal;

			// Token: 0x04000041 RID: 65
			[Token(Token = "0x4000041")]
			[FieldOffset(Offset = "0x40")]
			public float Radius;

			// Token: 0x04000042 RID: 66
			[Token(Token = "0x4000042")]
			[FieldOffset(Offset = "0x44")]
			public float Thickness;

			// Token: 0x04000043 RID: 67
			[Token(Token = "0x4000043")]
			[FieldOffset(Offset = "0x48")]
			public bool Solid;
		}

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		private class SquareData : DebugUtils.DebugData
		{
			// Token: 0x06000059 RID: 89 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
			public override void Draw()
			{
			}

			// Token: 0x0600005A RID: 90 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x2DBD860", Offset = "0x2DBBE60", VA = "0x182DBD860", Slot = "5")]
			public override void Dispose()
			{
			}

			// Token: 0x0600005B RID: 91 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SquareData()
			{
			}

			// Token: 0x04000044 RID: 68
			[Token(Token = "0x4000044")]
			[FieldOffset(Offset = "0x28")]
			public Color OutlineColor;

			// Token: 0x04000045 RID: 69
			[Token(Token = "0x4000045")]
			[FieldOffset(Offset = "0x38")]
			public Matrix4x4 LocalToWorldMatrix;

			// Token: 0x04000046 RID: 70
			[Token(Token = "0x4000046")]
			[FieldOffset(Offset = "0x78")]
			public Vector2 Size;
		}

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		private class BoxData : DebugUtils.DebugData
		{
			// Token: 0x0600005C RID: 92 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
			public override void Draw()
			{
			}

			// Token: 0x0600005D RID: 93 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x2DBD8C0", Offset = "0x2DBBEC0", VA = "0x182DBD8C0", Slot = "5")]
			public override void Dispose()
			{
			}

			// Token: 0x0600005E RID: 94 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public BoxData()
			{
			}

			// Token: 0x04000047 RID: 71
			[Token(Token = "0x4000047")]
			[FieldOffset(Offset = "0x28")]
			public Matrix4x4 LocalToWorldMatrix;

			// Token: 0x04000048 RID: 72
			[Token(Token = "0x4000048")]
			[FieldOffset(Offset = "0x68")]
			public Vector3 Size;

			// Token: 0x04000049 RID: 73
			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x74")]
			public float Thickness;
		}

		// Token: 0x02000010 RID: 16
		[Token(Token = "0x2000010")]
		private class SphereData : DebugUtils.DebugData
		{
			// Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
			public override void Draw()
			{
			}

			// Token: 0x06000060 RID: 96 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x2DBD920", Offset = "0x2DBBF20", VA = "0x182DBD920", Slot = "5")]
			public override void Dispose()
			{
			}

			// Token: 0x06000061 RID: 97 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SphereData()
			{
			}

			// Token: 0x0400004A RID: 74
			[Token(Token = "0x400004A")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 Center;

			// Token: 0x0400004B RID: 75
			[Token(Token = "0x400004B")]
			[FieldOffset(Offset = "0x34")]
			public float Radius;

			// Token: 0x0400004C RID: 76
			[Token(Token = "0x400004C")]
			[FieldOffset(Offset = "0x38")]
			public float Thickness;

			// Token: 0x0400004D RID: 77
			[Token(Token = "0x400004D")]
			[FieldOffset(Offset = "0x3C")]
			public bool Solid;
		}
	}
}
