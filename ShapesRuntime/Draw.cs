using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Shapes
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public static class Draw
	{
		// Token: 0x0600028E RID: 654 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x29A38D0", Offset = "0x29A1ED0", VA = "0x1829A38D0")]
		public static DrawCommand Command(Camera cam, CustomPassInjectionPoint cameraEvent = CustomPassInjectionPoint.BeforePostProcess)
		{
			return null;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x29A3950", Offset = "0x29A1F50", VA = "0x1829A3950")]
		[OvldGenCallTarget]
		private static void Line_Internal([OvldDefault("LineEndCaps")] LineEndCap endCaps, [OvldDefault("ThicknessSpace")] ThicknessSpace thicknessSpace, Vector3 start, Vector3 end, [OvldDefault("Color")] Color colorStart, [OvldDefault("Color")] Color colorEnd, [OvldDefault("Thickness")] float thickness)
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x29A4350", Offset = "0x29A2950", VA = "0x1829A4350")]
		[OvldGenCallTarget]
		private static void Polyline_Internal(PolylinePath path, [OvldDefault("false")] bool closed, [OvldDefault("PolylineGeometry")] PolylineGeometry geometry, [OvldDefault("PolylineJoins")] PolylineJoins joins, [OvldDefault("Thickness")] float thickness, [OvldDefault("ThicknessSpace")] ThicknessSpace thicknessSpace, [OvldDefault("Color")] Color color)
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x29A4880", Offset = "0x29A2E80", VA = "0x1829A4880")]
		[OvldGenCallTarget]
		private static void Polygon_Internal(PolygonPath path, [OvldDefault("PolygonTriangulation")] PolygonTriangulation triangulation, [OvldDefault("Color")] Color color)
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x29A4CC0", Offset = "0x29A32C0", VA = "0x1829A4CC0")]
		[OvldGenCallTarget]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Disc_Internal([OvldDefault("Radius")] float radius, [OvldDefault("Color")] DiscColors colors)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x29A4D70", Offset = "0x29A3370", VA = "0x1829A4D70")]
		[OvldGenCallTarget]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Ring_Internal([OvldDefault("Radius")] float radius, [OvldDefault("Thickness")] float thickness, [OvldDefault("Color")] DiscColors colors)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x29A4E30", Offset = "0x29A3430", VA = "0x1829A4E30")]
		[OvldGenCallTarget]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Pie_Internal([OvldDefault("Radius")] float radius, [OvldDefault("Color")] DiscColors colors, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x29A4F00", Offset = "0x29A3500", VA = "0x1829A4F00")]
		[OvldGenCallTarget]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Arc_Internal([OvldDefault("Radius")] float radius, [OvldDefault("Thickness")] float thickness, [OvldDefault("Color")] DiscColors colors, float angleRadStart, float angleRadEnd, [OvldDefault("ArcEndCap.None")] ArcEndCap endCaps)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x29A4FE0", Offset = "0x29A35E0", VA = "0x1829A4FE0")]
		private static void DiscCore(bool hollow, bool sector, float radius, float thickness, DiscColors colors, float angleRadStart = 0f, float angleRadEnd = 0f, ArcEndCap arcEndCaps = ArcEndCap.None)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x29A5E20", Offset = "0x29A4420", VA = "0x1829A5E20")]
		[OvldGenCallTarget]
		private static void RegularPolygon_Internal([OvldDefault("RegularPolygonSideCount")] int sideCount, [OvldDefault("Radius")] float radius, [OvldDefault("Thickness")] float thickness, [OvldDefault("Color")] Color color, bool hollow, [OvldDefault("0f")] float roundness, [OvldDefault("0f")] float angle)
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x29A67D0", Offset = "0x29A4DD0", VA = "0x1829A67D0")]
		[OvldGenCallTarget]
		private static void Rectangle_Internal([OvldDefault("BlendMode")] ShapesBlendMode blendMode, [OvldDefault("false")] bool hollow, Rect rect, [OvldDefault("Color")] Color color, [OvldDefault("Thickness")] float thickness, [OvldDefault("default")] Vector4 cornerRadii)
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x29A6F60", Offset = "0x29A5560", VA = "0x1829A6F60")]
		[OvldGenCallTarget]
		private static void Triangle_Internal(Vector3 a, Vector3 b, Vector3 c, bool hollow, [OvldDefault("Thickness")] float thickness, [OvldDefault("0f")] float roundness, [OvldDefault("Color")] Color colorA, [OvldDefault("Color")] Color colorB, [OvldDefault("Color")] Color colorC)
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x29A7B60", Offset = "0x29A6160", VA = "0x1829A7B60")]
		[OvldGenCallTarget]
		private static void Quad_Internal(Vector3 a, Vector3 b, Vector3 c, [OvldDefault("a + ( c - b )")] Vector3 d, [OvldDefault("Color")] Color colorA, [OvldDefault("Color")] Color colorB, [OvldDefault("Color")] Color colorC, [OvldDefault("Color")] Color colorD)
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x29A85A0", Offset = "0x29A6BA0", VA = "0x1829A85A0")]
		[OvldGenCallTarget]
		private static void Sphere_Internal([OvldDefault("Radius")] float radius, [OvldDefault("Color")] Color color)
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x29A8AB0", Offset = "0x29A70B0", VA = "0x1829A8AB0")]
		[OvldGenCallTarget]
		private static void Cone_Internal(float radius, float length, [OvldDefault("true")] bool fillCap, [OvldDefault("Color")] Color color)
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x29A9040", Offset = "0x29A7640", VA = "0x1829A9040")]
		[OvldGenCallTarget]
		private static void Cuboid_Internal(Vector3 size, [OvldDefault("Color")] Color color)
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x29A9540", Offset = "0x29A7B40", VA = "0x1829A9540")]
		[OvldGenCallTarget]
		private static void Torus_Internal(float radius, float thickness, [OvldDefault("0")] float angStart, [OvldDefault("ShapesMath.TAU")] float angEnd, [OvldDefault("Color")] Color color)
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x29A9B70", Offset = "0x29A8170", VA = "0x1829A9B70")]
		[OvldGenCallTarget]
		private static void Text_Internal(string content, [OvldDefault("Font")] TMP_FontAsset font, [OvldDefault("FontSize")] float fontSize, [OvldDefault("TextAlign")] TextAlign align, [OvldDefault("Color")] Color color)
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x29AA930", Offset = "0x29A8F30", VA = "0x1829AA930")]
		[OvldGenCallTarget]
		private static void Texture_Internal(Texture texture, Rect rect, Rect uvs, [OvldDefault("Color")] Color color)
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x29AAEC0", Offset = "0x29A94C0", VA = "0x1829AAEC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Texture_Placement_Internal(Texture texture, [TupleElementNames(new string[]
		{
			"rect",
			"uvs"
		})] ValueTuple<Rect, Rect> placement, Color color)
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x29AAF80", Offset = "0x29A9580", VA = "0x1829AAF80")]
		[OvldGenCallTarget]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Texture_RectFill_Internal(Texture texture, Rect rect, [OvldDefault("TextureFillMode.ScaleToFit")] TextureFillMode fillMode, [OvldDefault("Color")] Color color)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x29AB0B0", Offset = "0x29A96B0", VA = "0x1829AB0B0")]
		[OvldGenCallTarget]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Texture_PosSize_Internal(Texture texture, Vector2 center, float size, [OvldDefault("TextureSizeMode.LongestSide")] TextureSizeMode sizeMode, [OvldDefault("Color")] Color color)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x29AB1E0", Offset = "0x29A97E0", VA = "0x1829AB1E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Line(Vector3 start, Vector3 end)
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x29AB430", Offset = "0x29A9A30", VA = "0x1829AB430")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Line(Vector3 start, Vector3 end, Color color)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x29AB5E0", Offset = "0x29A9BE0", VA = "0x1829AB5E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Line(Vector3 start, Vector3 end, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x29AB7A0", Offset = "0x29A9DA0", VA = "0x1829AB7A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Line(Vector3 start, Vector3 end, float thickness)
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x29AB9A0", Offset = "0x29A9FA0", VA = "0x1829AB9A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Line(Vector3 start, Vector3 end, float thickness, Color color)
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x29ABB10", Offset = "0x29AA110", VA = "0x1829ABB10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Line(Vector3 start, Vector3 end, float thickness, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x29ABC80", Offset = "0x29AA280", VA = "0x1829ABC80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Line(Vector3 start, Vector3 end, LineEndCap endCaps)
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x29ABE80", Offset = "0x29AA480", VA = "0x1829ABE80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Line(Vector3 start, Vector3 end, LineEndCap endCaps, Color color)
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x29ABFF0", Offset = "0x29AA5F0", VA = "0x1829ABFF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Line(Vector3 start, Vector3 end, LineEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x29AC170", Offset = "0x29AA770", VA = "0x1829AC170")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Line(Vector3 start, Vector3 end, float thickness, LineEndCap endCaps)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x29AC330", Offset = "0x29AA930", VA = "0x1829AC330")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Line(Vector3 start, Vector3 end, float thickness, LineEndCap endCaps, Color color)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x29AC460", Offset = "0x29AAA60", VA = "0x1829AC460")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Line(Vector3 start, Vector3 end, float thickness, LineEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x29AC590", Offset = "0x29AAB90", VA = "0x1829AC590")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polyline(PolylinePath path)
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x29AC790", Offset = "0x29AAD90", VA = "0x1829AC790")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polyline(PolylinePath path, bool closed)
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x29AC9A0", Offset = "0x29AAFA0", VA = "0x1829AC9A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polyline(PolylinePath path, float thickness)
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x29ACB60", Offset = "0x29AB160", VA = "0x1829ACB60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polyline(PolylinePath path, bool closed, float thickness)
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x29ACD30", Offset = "0x29AB330", VA = "0x1829ACD30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polyline(PolylinePath path, PolylineJoins joins)
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x29ACEF0", Offset = "0x29AB4F0", VA = "0x1829ACEF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polyline(PolylinePath path, bool closed, PolylineJoins joins)
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x29AD0C0", Offset = "0x29AB6C0", VA = "0x1829AD0C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polyline(PolylinePath path, float thickness, PolylineJoins joins)
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x29AD240", Offset = "0x29AB840", VA = "0x1829AD240")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polyline(PolylinePath path, bool closed, float thickness, PolylineJoins joins)
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x29AD3C0", Offset = "0x29AB9C0", VA = "0x1829AD3C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polyline(PolylinePath path, Color color)
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x29AD580", Offset = "0x29ABB80", VA = "0x1829AD580")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polyline(PolylinePath path, bool closed, Color color)
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x29AD750", Offset = "0x29ABD50", VA = "0x1829AD750")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polyline(PolylinePath path, float thickness, Color color)
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x29AD8D0", Offset = "0x29ABED0", VA = "0x1829AD8D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polyline(PolylinePath path, bool closed, float thickness, Color color)
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x29ADA60", Offset = "0x29AC060", VA = "0x1829ADA60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polyline(PolylinePath path, PolylineJoins joins, Color color)
		{
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x29ADBE0", Offset = "0x29AC1E0", VA = "0x1829ADBE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polyline(PolylinePath path, bool closed, PolylineJoins joins, Color color)
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x29ADD70", Offset = "0x29AC370", VA = "0x1829ADD70")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polyline(PolylinePath path, float thickness, PolylineJoins joins, Color color)
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x29ADEB0", Offset = "0x29AC4B0", VA = "0x1829ADEB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polyline(PolylinePath path, bool closed, float thickness, PolylineJoins joins, Color color)
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x29ADFF0", Offset = "0x29AC5F0", VA = "0x1829ADFF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polygon(PolygonPath path)
		{
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x29AE0E0", Offset = "0x29AC6E0", VA = "0x1829AE0E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polygon(PolygonPath path, Color color)
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x29AE190", Offset = "0x29AC790", VA = "0x1829AE190")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polygon(PolygonPath path, PolygonTriangulation triangulation)
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x29AE240", Offset = "0x29AC840", VA = "0x1829AE240")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Polygon(PolygonPath path, PolygonTriangulation triangulation, Color color)
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x29AE2C0", Offset = "0x29AC8C0", VA = "0x1829AE2C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos)
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x29AE500", Offset = "0x29ACB00", VA = "0x1829AE500")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Color color)
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x29AE700", Offset = "0x29ACD00", VA = "0x1829AE700")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, float radius)
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x29AE900", Offset = "0x29ACF00", VA = "0x1829AE900")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, float radius, Color color)
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x29AEAB0", Offset = "0x29AD0B0", VA = "0x1829AEAB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, float radius, float angle)
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x29AECC0", Offset = "0x29AD2C0", VA = "0x1829AECC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, float radius, float angle, Color color)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x29AEE80", Offset = "0x29AD480", VA = "0x1829AEE80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, float radius, float angle, float roundness)
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x29AF0A0", Offset = "0x29AD6A0", VA = "0x1829AF0A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, float radius, float angle, float roundness, Color color)
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x29AF270", Offset = "0x29AD870", VA = "0x1829AF270")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, int sideCount)
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x29AF470", Offset = "0x29ADA70", VA = "0x1829AF470")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, int sideCount, Color color)
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x29AF630", Offset = "0x29ADC30", VA = "0x1829AF630")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, int sideCount, float radius)
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x29AF7F0", Offset = "0x29ADDF0", VA = "0x1829AF7F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, int sideCount, float radius, Color color)
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x29AF970", Offset = "0x29ADF70", VA = "0x1829AF970")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, int sideCount, float radius, float angle)
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x29AFB50", Offset = "0x29AE150", VA = "0x1829AFB50")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, int sideCount, float radius, float angle, Color color)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x29AFCD0", Offset = "0x29AE2D0", VA = "0x1829AFCD0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, int sideCount, float radius, float angle, float roundness)
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x29AFEB0", Offset = "0x29AE4B0", VA = "0x1829AFEB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, int sideCount, float radius, float angle, float roundness, Color color)
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x29B0040", Offset = "0x29AE640", VA = "0x1829B0040")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Vector3 normal)
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x29B04D0", Offset = "0x29AEAD0", VA = "0x1829B04D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Vector3 normal, Color color)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x29B0920", Offset = "0x29AEF20", VA = "0x1829B0920")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Vector3 normal, float radius)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x29B0D80", Offset = "0x29AF380", VA = "0x1829B0D80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Vector3 normal, float radius, Color color)
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x29B11A0", Offset = "0x29AF7A0", VA = "0x1829B11A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Vector3 normal, float radius, float angle)
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x29B1610", Offset = "0x29AFC10", VA = "0x1829B1610")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Vector3 normal, float radius, float angle, Color color)
		{
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x29B1A40", Offset = "0x29B0040", VA = "0x1829B1A40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Vector3 normal, float radius, float angle, float roundness)
		{
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x29B1EB0", Offset = "0x29B04B0", VA = "0x1829B1EB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Vector3 normal, float radius, float angle, float roundness, Color color)
		{
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x29B22E0", Offset = "0x29B08E0", VA = "0x1829B22E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Vector3 normal, int sideCount)
		{
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x29B2730", Offset = "0x29B0D30", VA = "0x1829B2730")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Vector3 normal, int sideCount, Color color)
		{
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x29B2B50", Offset = "0x29B1150", VA = "0x1829B2B50")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Vector3 normal, int sideCount, float radius)
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x29B2F70", Offset = "0x29B1570", VA = "0x1829B2F70")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Vector3 normal, int sideCount, float radius, Color color)
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x29B3350", Offset = "0x29B1950", VA = "0x1829B3350")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Vector3 normal, int sideCount, float radius, float angle)
		{
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x29B3780", Offset = "0x29B1D80", VA = "0x1829B3780")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Vector3 normal, int sideCount, float radius, float angle, Color color)
		{
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x29B3B70", Offset = "0x29B2170", VA = "0x1829B3B70")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Vector3 normal, int sideCount, float radius, float angle, float roundness)
		{
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x29B3FA0", Offset = "0x29B25A0", VA = "0x1829B3FA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Vector3 normal, int sideCount, float radius, float angle, float roundness, Color color)
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x29B4390", Offset = "0x29B2990", VA = "0x1829B4390")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x29B4780", Offset = "0x29B2D80", VA = "0x1829B4780")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Quaternion rot, Color color)
		{
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x29B4B30", Offset = "0x29B3130", VA = "0x1829B4B30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Quaternion rot, float radius)
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x29B4EE0", Offset = "0x29B34E0", VA = "0x1829B4EE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Quaternion rot, float radius, Color color)
		{
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x29B5260", Offset = "0x29B3860", VA = "0x1829B5260")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Quaternion rot, float radius, float angle)
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x29B5620", Offset = "0x29B3C20", VA = "0x1829B5620")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Quaternion rot, float radius, float angle, Color color)
		{
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x29B59B0", Offset = "0x29B3FB0", VA = "0x1829B59B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Quaternion rot, float radius, float angle, float roundness)
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x29B5D80", Offset = "0x29B4380", VA = "0x1829B5D80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Quaternion rot, float radius, float angle, float roundness, Color color)
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x29B6110", Offset = "0x29B4710", VA = "0x1829B6110")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Quaternion rot, int sideCount)
		{
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x29B64C0", Offset = "0x29B4AC0", VA = "0x1829B64C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Quaternion rot, int sideCount, Color color)
		{
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x29B6830", Offset = "0x29B4E30", VA = "0x1829B6830")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Quaternion rot, int sideCount, float radius)
		{
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x29B6BB0", Offset = "0x29B51B0", VA = "0x1829B6BB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Quaternion rot, int sideCount, float radius, Color color)
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x29B6EF0", Offset = "0x29B54F0", VA = "0x1829B6EF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Quaternion rot, int sideCount, float radius, float angle)
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x29B7270", Offset = "0x29B5870", VA = "0x1829B7270")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Quaternion rot, int sideCount, float radius, float angle, Color color)
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x29B75B0", Offset = "0x29B5BB0", VA = "0x1829B75B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Quaternion rot, int sideCount, float radius, float angle, float roundness)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x29B7940", Offset = "0x29B5F40", VA = "0x1829B7940")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Vector3 pos, Quaternion rot, int sideCount, float radius, float angle, float roundness, Color color)
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x29B7C90", Offset = "0x29B6290", VA = "0x1829B7C90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon()
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x29B7E30", Offset = "0x29B6430", VA = "0x1829B7E30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(Color color)
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x29B7F90", Offset = "0x29B6590", VA = "0x1829B7F90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(float radius)
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x29B80F0", Offset = "0x29B66F0", VA = "0x1829B80F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(float radius, Color color)
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x29B8210", Offset = "0x29B6810", VA = "0x1829B8210")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(float radius, float angle)
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x29B8390", Offset = "0x29B6990", VA = "0x1829B8390")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(float radius, float angle, Color color)
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x29B84C0", Offset = "0x29B6AC0", VA = "0x1829B84C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(float radius, float angle, float roundness)
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x29B8640", Offset = "0x29B6C40", VA = "0x1829B8640")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(float radius, float angle, float roundness, Color color)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x29B8780", Offset = "0x29B6D80", VA = "0x1829B8780")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(int sideCount)
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x29B88E0", Offset = "0x29B6EE0", VA = "0x1829B88E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(int sideCount, Color color)
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x29B8A00", Offset = "0x29B7000", VA = "0x1829B8A00")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(int sideCount, float radius)
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x29B8B20", Offset = "0x29B7120", VA = "0x1829B8B20")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(int sideCount, float radius, Color color)
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x29B8C00", Offset = "0x29B7200", VA = "0x1829B8C00")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(int sideCount, float radius, float angle)
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x29B8D30", Offset = "0x29B7330", VA = "0x1829B8D30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(int sideCount, float radius, float angle, Color color)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x29B8E20", Offset = "0x29B7420", VA = "0x1829B8E20")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(int sideCount, float radius, float angle, float roundness)
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x29B8F60", Offset = "0x29B7560", VA = "0x1829B8F60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygon(int sideCount, float radius, float angle, float roundness, Color color)
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x29B9050", Offset = "0x29B7650", VA = "0x1829B9050")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos)
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x29B9290", Offset = "0x29B7890", VA = "0x1829B9290")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Color color)
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x29B9490", Offset = "0x29B7A90", VA = "0x1829B9490")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, float radius)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x29B9690", Offset = "0x29B7C90", VA = "0x1829B9690")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, float radius, Color color)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x29B9840", Offset = "0x29B7E40", VA = "0x1829B9840")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, float radius, float thickness)
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x29B99F0", Offset = "0x29B7FF0", VA = "0x1829B99F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, float radius, float thickness, Color color)
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x29B9B70", Offset = "0x29B8170", VA = "0x1829B9B70")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, float radius, float thickness, float angle)
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x29B9D40", Offset = "0x29B8340", VA = "0x1829B9D40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, float radius, float thickness, float angle, Color color)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x29B9ED0", Offset = "0x29B84D0", VA = "0x1829B9ED0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x29BA0A0", Offset = "0x29B86A0", VA = "0x1829BA0A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, float radius, float thickness, float angle, float roundness, Color color)
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x29BA230", Offset = "0x29B8830", VA = "0x1829BA230")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, int sideCount)
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x29BA430", Offset = "0x29B8A30", VA = "0x1829BA430")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, int sideCount, Color color)
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x29BA5F0", Offset = "0x29B8BF0", VA = "0x1829BA5F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, int sideCount, float radius)
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x29BA7B0", Offset = "0x29B8DB0", VA = "0x1829BA7B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, int sideCount, float radius, Color color)
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x29BA930", Offset = "0x29B8F30", VA = "0x1829BA930")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, int sideCount, float radius, float thickness)
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x29BAAB0", Offset = "0x29B90B0", VA = "0x1829BAAB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, int sideCount, float radius, float thickness, Color color)
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x29BABF0", Offset = "0x29B91F0", VA = "0x1829BABF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, int sideCount, float radius, float thickness, float angle)
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x29BAD80", Offset = "0x29B9380", VA = "0x1829BAD80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, int sideCount, float radius, float thickness, float angle, Color color)
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x29BAED0", Offset = "0x29B94D0", VA = "0x1829BAED0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, int sideCount, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x29BB060", Offset = "0x29B9660", VA = "0x1829BB060")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, int sideCount, float radius, float thickness, float angle, float roundness, Color color)
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x29BB1B0", Offset = "0x29B97B0", VA = "0x1829BB1B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal)
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x29BB640", Offset = "0x29B9C40", VA = "0x1829BB640")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, Color color)
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x29BBA90", Offset = "0x29BA090", VA = "0x1829BBA90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, float radius)
		{
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x29BBEF0", Offset = "0x29BA4F0", VA = "0x1829BBEF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, float radius, Color color)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x29BC310", Offset = "0x29BA910", VA = "0x1829BC310")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, float radius, float thickness)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x29BC730", Offset = "0x29BAD30", VA = "0x1829BC730")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, float radius, float thickness, Color color)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x29BCB10", Offset = "0x29BB110", VA = "0x1829BCB10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, float radius, float thickness, float angle)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x29BCF40", Offset = "0x29BB540", VA = "0x1829BCF40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, float radius, float thickness, float angle, Color color)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x29BD330", Offset = "0x29BB930", VA = "0x1829BD330")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x29BD760", Offset = "0x29BBD60", VA = "0x1829BD760")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, float radius, float thickness, float angle, float roundness, Color color)
		{
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x29BDB50", Offset = "0x29BC150", VA = "0x1829BDB50")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, int sideCount)
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x29BDFA0", Offset = "0x29BC5A0", VA = "0x1829BDFA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, int sideCount, Color color)
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x29BE3C0", Offset = "0x29BC9C0", VA = "0x1829BE3C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, int sideCount, float radius)
		{
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x29BE7E0", Offset = "0x29BCDE0", VA = "0x1829BE7E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, int sideCount, float radius, Color color)
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x29BEBC0", Offset = "0x29BD1C0", VA = "0x1829BEBC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x29BEFA0", Offset = "0x29BD5A0", VA = "0x1829BEFA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, Color color)
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x29BF340", Offset = "0x29BD940", VA = "0x1829BF340")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, float angle)
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x29BF730", Offset = "0x29BDD30", VA = "0x1829BF730")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, float angle, Color color)
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x29BFAE0", Offset = "0x29BE0E0", VA = "0x1829BFAE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x29BFED0", Offset = "0x29BE4D0", VA = "0x1829BFED0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, float angle, float roundness, Color color)
		{
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x29C0280", Offset = "0x29BE880", VA = "0x1829C0280")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x29C0670", Offset = "0x29BEC70", VA = "0x1829C0670")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, Color color)
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x29C0A20", Offset = "0x29BF020", VA = "0x1829C0A20")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, float radius)
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x29C0DD0", Offset = "0x29BF3D0", VA = "0x1829C0DD0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, float radius, Color color)
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x29C1150", Offset = "0x29BF750", VA = "0x1829C1150")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, float radius, float thickness)
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x29C14D0", Offset = "0x29BFAD0", VA = "0x1829C14D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, float radius, float thickness, Color color)
		{
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x29C1810", Offset = "0x29BFE10", VA = "0x1829C1810")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, float radius, float thickness, float angle)
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x29C1BA0", Offset = "0x29C01A0", VA = "0x1829C1BA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, float radius, float thickness, float angle, Color color)
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x29C1EF0", Offset = "0x29C04F0", VA = "0x1829C1EF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x29C2280", Offset = "0x29C0880", VA = "0x1829C2280")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, float radius, float thickness, float angle, float roundness, Color color)
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x29C25D0", Offset = "0x29C0BD0", VA = "0x1829C25D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, int sideCount)
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x29C2980", Offset = "0x29C0F80", VA = "0x1829C2980")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, int sideCount, Color color)
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x29C2CF0", Offset = "0x29C12F0", VA = "0x1829C2CF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, int sideCount, float radius)
		{
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x29C3070", Offset = "0x29C1670", VA = "0x1829C3070")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, int sideCount, float radius, Color color)
		{
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x29C33B0", Offset = "0x29C19B0", VA = "0x1829C33B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness)
		{
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x29C36F0", Offset = "0x29C1CF0", VA = "0x1829C36F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, Color color)
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x29C39F0", Offset = "0x29C1FF0", VA = "0x1829C39F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, float angle)
		{
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x29C3D30", Offset = "0x29C2330", VA = "0x1829C3D30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, float angle, Color color)
		{
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x29C4030", Offset = "0x29C2630", VA = "0x1829C4030")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x29C4380", Offset = "0x29C2980", VA = "0x1829C4380")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, float angle, float roundness, Color color)
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x29C4690", Offset = "0x29C2C90", VA = "0x1829C4690")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder()
		{
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x29C4830", Offset = "0x29C2E30", VA = "0x1829C4830")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(Color color)
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x29C4990", Offset = "0x29C2F90", VA = "0x1829C4990")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(float radius)
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x29C4AF0", Offset = "0x29C30F0", VA = "0x1829C4AF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(float radius, Color color)
		{
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x29C4C10", Offset = "0x29C3210", VA = "0x1829C4C10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(float radius, float thickness)
		{
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x29C4D30", Offset = "0x29C3330", VA = "0x1829C4D30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(float radius, float thickness, Color color)
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x29C4E10", Offset = "0x29C3410", VA = "0x1829C4E10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(float radius, float thickness, float angle)
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x29C4F40", Offset = "0x29C3540", VA = "0x1829C4F40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(float radius, float thickness, float angle, Color color)
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x29C5030", Offset = "0x29C3630", VA = "0x1829C5030")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x29C5170", Offset = "0x29C3770", VA = "0x1829C5170")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(float radius, float thickness, float angle, float roundness, Color color)
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x29C5270", Offset = "0x29C3870", VA = "0x1829C5270")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(int sideCount)
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x29C53D0", Offset = "0x29C39D0", VA = "0x1829C53D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(int sideCount, Color color)
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x29C54F0", Offset = "0x29C3AF0", VA = "0x1829C54F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(int sideCount, float radius)
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x29C5610", Offset = "0x29C3C10", VA = "0x1829C5610")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(int sideCount, float radius, Color color)
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x29C56F0", Offset = "0x29C3CF0", VA = "0x1829C56F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(int sideCount, float radius, float thickness)
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x29C57D0", Offset = "0x29C3DD0", VA = "0x1829C57D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(int sideCount, float radius, float thickness, Color color)
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x29C5870", Offset = "0x29C3E70", VA = "0x1829C5870")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(int sideCount, float radius, float thickness, float angle)
		{
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x29C5960", Offset = "0x29C3F60", VA = "0x1829C5960")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(int sideCount, float radius, float thickness, float angle, Color color)
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x29C5A10", Offset = "0x29C4010", VA = "0x1829C5A10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(int sideCount, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x29C5B00", Offset = "0x29C4100", VA = "0x1829C5B00")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RegularPolygonBorder(int sideCount, float radius, float thickness, float angle, float roundness, Color color)
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x29C5BC0", Offset = "0x29C41C0", VA = "0x1829C5BC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Disc(Vector3 pos)
		{
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x29C5D60", Offset = "0x29C4360", VA = "0x1829C5D60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Disc(Vector3 pos, DiscColors colors)
		{
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x29C5EC0", Offset = "0x29C44C0", VA = "0x1829C5EC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Disc(Vector3 pos, float radius)
		{
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x29C6020", Offset = "0x29C4620", VA = "0x1829C6020")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Disc(Vector3 pos, float radius, DiscColors colors)
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x29C6150", Offset = "0x29C4750", VA = "0x1829C6150")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Disc(Vector3 pos, Vector3 normal)
		{
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x29C6540", Offset = "0x29C4B40", VA = "0x1829C6540")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Disc(Vector3 pos, Vector3 normal, DiscColors colors)
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x29C6900", Offset = "0x29C4F00", VA = "0x1829C6900")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Disc(Vector3 pos, Vector3 normal, float radius)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x29C6CC0", Offset = "0x29C52C0", VA = "0x1829C6CC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Disc(Vector3 pos, Vector3 normal, float radius, DiscColors colors)
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x29C7050", Offset = "0x29C5650", VA = "0x1829C7050")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Disc(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x29C73A0", Offset = "0x29C59A0", VA = "0x1829C73A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Disc(Vector3 pos, Quaternion rot, DiscColors colors)
		{
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x29C76C0", Offset = "0x29C5CC0", VA = "0x1829C76C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Disc(Vector3 pos, Quaternion rot, float radius)
		{
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x29C79E0", Offset = "0x29C5FE0", VA = "0x1829C79E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Disc(Vector3 pos, Quaternion rot, float radius, DiscColors colors)
		{
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x29C7CD0", Offset = "0x29C62D0", VA = "0x1829C7CD0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Disc()
		{
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x29C7DD0", Offset = "0x29C63D0", VA = "0x1829C7DD0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Disc(DiscColors colors)
		{
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x29C7E90", Offset = "0x29C6490", VA = "0x1829C7E90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Disc(float radius)
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x29C7F40", Offset = "0x29C6540", VA = "0x1829C7F40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Disc(float radius, DiscColors colors)
		{
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x29C7FC0", Offset = "0x29C65C0", VA = "0x1829C7FC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos)
		{
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x29C81B0", Offset = "0x29C67B0", VA = "0x1829C81B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, DiscColors colors)
		{
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x29C8370", Offset = "0x29C6970", VA = "0x1829C8370")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, float radius)
		{
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x29C8520", Offset = "0x29C6B20", VA = "0x1829C8520")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, float radius, DiscColors colors)
		{
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x29C86A0", Offset = "0x29C6CA0", VA = "0x1829C86A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, float radius, float thickness)
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x29C8810", Offset = "0x29C6E10", VA = "0x1829C8810")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, float radius, float thickness, DiscColors colors)
		{
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x29C8950", Offset = "0x29C6F50", VA = "0x1829C8950")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, Vector3 normal)
		{
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x29C8D90", Offset = "0x29C7390", VA = "0x1829C8D90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, Vector3 normal, DiscColors colors)
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x29C91A0", Offset = "0x29C77A0", VA = "0x1829C91A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, Vector3 normal, float radius)
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x29C95A0", Offset = "0x29C7BA0", VA = "0x1829C95A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, Vector3 normal, float radius, DiscColors colors)
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x29C9980", Offset = "0x29C7F80", VA = "0x1829C9980")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, Vector3 normal, float radius, float thickness)
		{
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x29C9D50", Offset = "0x29C8350", VA = "0x1829C9D50")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, Vector3 normal, float radius, float thickness, DiscColors colors)
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x29CA0F0", Offset = "0x29C86F0", VA = "0x1829CA0F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x29CA490", Offset = "0x29C8A90", VA = "0x1829CA490")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, Quaternion rot, DiscColors colors)
		{
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x29CA800", Offset = "0x29C8E00", VA = "0x1829CA800")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, Quaternion rot, float radius)
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x29CAB60", Offset = "0x29C9160", VA = "0x1829CAB60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, Quaternion rot, float radius, DiscColors colors)
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x29CAE90", Offset = "0x29C9490", VA = "0x1829CAE90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, Quaternion rot, float radius, float thickness)
		{
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x29CB1C0", Offset = "0x29C97C0", VA = "0x1829CB1C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(Vector3 pos, Quaternion rot, float radius, float thickness, DiscColors colors)
		{
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x29CB4C0", Offset = "0x29C9AC0", VA = "0x1829CB4C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring()
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x29CB610", Offset = "0x29C9C10", VA = "0x1829CB610")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(DiscColors colors)
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x29CB720", Offset = "0x29C9D20", VA = "0x1829CB720")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(float radius)
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x29CB830", Offset = "0x29C9E30", VA = "0x1829CB830")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(float radius, DiscColors colors)
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x29CB900", Offset = "0x29C9F00", VA = "0x1829CB900")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(float radius, float thickness)
		{
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x29CB9D0", Offset = "0x29C9FD0", VA = "0x1829CB9D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Ring(float radius, float thickness, DiscColors colors)
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x29CBA70", Offset = "0x29CA070", VA = "0x1829CBA70")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pie(Vector3 pos, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x29CBC30", Offset = "0x29CA230", VA = "0x1829CBC30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pie(Vector3 pos, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x29CBDC0", Offset = "0x29CA3C0", VA = "0x1829CBDC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pie(Vector3 pos, float radius, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x29CBF40", Offset = "0x29CA540", VA = "0x1829CBF40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pie(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x29CC090", Offset = "0x29CA690", VA = "0x1829CC090")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pie(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x29CC4A0", Offset = "0x29CAAA0", VA = "0x1829CC4A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pie(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x29CC880", Offset = "0x29CAE80", VA = "0x1829CC880")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pie(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x29CCC60", Offset = "0x29CB260", VA = "0x1829CCC60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pie(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x29CD000", Offset = "0x29CB600", VA = "0x1829CD000")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pie(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x29CD370", Offset = "0x29CB970", VA = "0x1829CD370")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pie(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x29CD6B0", Offset = "0x29CBCB0", VA = "0x1829CD6B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pie(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x29CD9E0", Offset = "0x29CBFE0", VA = "0x1829CD9E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pie(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x29CDCE0", Offset = "0x29CC2E0", VA = "0x1829CDCE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pie(float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x29CDE10", Offset = "0x29CC410", VA = "0x1829CDE10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pie(float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x29CDEF0", Offset = "0x29CC4F0", VA = "0x1829CDEF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pie(float radius, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x29CDFD0", Offset = "0x29CC5D0", VA = "0x1829CDFD0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pie(float radius, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x29CE080", Offset = "0x29CC680", VA = "0x1829CE080")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x29CE2A0", Offset = "0x29CC8A0", VA = "0x1829CE2A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x29CE490", Offset = "0x29CCA90", VA = "0x1829CE490")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x29CE6C0", Offset = "0x29CCCC0", VA = "0x1829CE6C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, DiscColors colors)
		{
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x29CE8B0", Offset = "0x29CCEB0", VA = "0x1829CE8B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, float radius, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x29CEA90", Offset = "0x29CD090", VA = "0x1829CEA90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x29CEC30", Offset = "0x29CD230", VA = "0x1829CEC30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x29CEE10", Offset = "0x29CD410", VA = "0x1829CEE10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, DiscColors colors)
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x29CEFB0", Offset = "0x29CD5B0", VA = "0x1829CEFB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x29CF150", Offset = "0x29CD750", VA = "0x1829CF150")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x29CF2B0", Offset = "0x29CD8B0", VA = "0x1829CF2B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x29CF450", Offset = "0x29CDA50", VA = "0x1829CF450")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, DiscColors colors)
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x29CF5C0", Offset = "0x29CDBC0", VA = "0x1829CF5C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x29CFA30", Offset = "0x29CE030", VA = "0x1829CFA30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x29CFE60", Offset = "0x29CE460", VA = "0x1829CFE60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x29D02D0", Offset = "0x29CE8D0", VA = "0x1829D02D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, DiscColors colors)
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x29D0710", Offset = "0x29CED10", VA = "0x1829D0710")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x29D0B40", Offset = "0x29CF140", VA = "0x1829D0B40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x29D0F30", Offset = "0x29CF530", VA = "0x1829D0F30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x29D1360", Offset = "0x29CF960", VA = "0x1829D1360")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, DiscColors colors)
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x29D1760", Offset = "0x29CFD60", VA = "0x1829D1760")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x29D1B50", Offset = "0x29D0150", VA = "0x1829D1B50")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x29D1F10", Offset = "0x29D0510", VA = "0x1829D1F10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x29D2300", Offset = "0x29D0900", VA = "0x1829D2300")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, DiscColors colors)
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x29D26C0", Offset = "0x29D0CC0", VA = "0x1829D26C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x29D2A80", Offset = "0x29D1080", VA = "0x1829D2A80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x29D2E10", Offset = "0x29D1410", VA = "0x1829D2E10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x29D31D0", Offset = "0x29D17D0", VA = "0x1829D31D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, DiscColors colors)
		{
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x29D3560", Offset = "0x29D1B60", VA = "0x1829D3560")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x29D38E0", Offset = "0x29D1EE0", VA = "0x1829D38E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x29D3C30", Offset = "0x29D2230", VA = "0x1829D3C30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x29D3FB0", Offset = "0x29D25B0", VA = "0x1829D3FB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, DiscColors colors)
		{
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x29D4310", Offset = "0x29D2910", VA = "0x1829D4310")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x29D4650", Offset = "0x29D2C50", VA = "0x1829D4650")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x29D4960", Offset = "0x29D2F60", VA = "0x1829D4960")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x29D4CB0", Offset = "0x29D32B0", VA = "0x1829D4CB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, DiscColors colors)
		{
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x29D4FD0", Offset = "0x29D35D0", VA = "0x1829D4FD0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x29D5150", Offset = "0x29D3750", VA = "0x1829D5150")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x29D5290", Offset = "0x29D3890", VA = "0x1829D5290")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x29D5420", Offset = "0x29D3A20", VA = "0x1829D5420")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(float angleRadStart, float angleRadEnd, ArcEndCap endCaps, DiscColors colors)
		{
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x29D5570", Offset = "0x29D3B70", VA = "0x1829D5570")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(float radius, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x29D56B0", Offset = "0x29D3CB0", VA = "0x1829D56B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(float radius, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x29D57B0", Offset = "0x29D3DB0", VA = "0x1829D57B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x29D58F0", Offset = "0x29D3EF0", VA = "0x1829D58F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, DiscColors colors)
		{
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x29D59F0", Offset = "0x29D3FF0", VA = "0x1829D59F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(float radius, float thickness, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x29D5AF0", Offset = "0x29D40F0", VA = "0x1829D5AF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(float radius, float thickness, float angleRadStart, float angleRadEnd, DiscColors colors)
		{
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x29D5BC0", Offset = "0x29D41C0", VA = "0x1829D5BC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x29D5CC0", Offset = "0x29D42C0", VA = "0x1829D5CC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Arc(float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, DiscColors colors)
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x29D5D90", Offset = "0x29D4390", VA = "0x1829D5D90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Rect rect)
		{
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x29D5FA0", Offset = "0x29D45A0", VA = "0x1829D5FA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Rect rect, Color color)
		{
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x29D6170", Offset = "0x29D4770", VA = "0x1829D6170")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Rect rect, float cornerRadius)
		{
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x29D63A0", Offset = "0x29D49A0", VA = "0x1829D63A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Rect rect, float cornerRadius, Color color)
		{
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x29D6590", Offset = "0x29D4B90", VA = "0x1829D6590")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Rect rect, Vector4 cornerRadii)
		{
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x29D67B0", Offset = "0x29D4DB0", VA = "0x1829D67B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Rect rect, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x29D6980", Offset = "0x29D4F80", VA = "0x1829D6980")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Rect rect)
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x29D6DE0", Offset = "0x29D53E0", VA = "0x1829D6DE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Rect rect, Color color)
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x29D7210", Offset = "0x29D5810", VA = "0x1829D7210")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Rect rect, float cornerRadius)
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x29D7690", Offset = "0x29D5C90", VA = "0x1829D7690")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Rect rect, float cornerRadius, Color color)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x29D7AD0", Offset = "0x29D60D0", VA = "0x1829D7AD0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Rect rect, Vector4 cornerRadii)
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x29D7F40", Offset = "0x29D6540", VA = "0x1829D7F40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Rect rect, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x29D8370", Offset = "0x29D6970", VA = "0x1829D8370")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Rect rect)
		{
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x29D8730", Offset = "0x29D6D30", VA = "0x1829D8730")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Rect rect, Color color)
		{
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x29D8AB0", Offset = "0x29D70B0", VA = "0x1829D8AB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Rect rect, float cornerRadius)
		{
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x29D8E80", Offset = "0x29D7480", VA = "0x1829D8E80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Rect rect, float cornerRadius, Color color)
		{
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x29D9220", Offset = "0x29D7820", VA = "0x1829D9220")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Rect rect, Vector4 cornerRadii)
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x29D95F0", Offset = "0x29D7BF0", VA = "0x1829D95F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Rect rect, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x29D9980", Offset = "0x29D7F80", VA = "0x1829D9980")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector2 size)
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x29D9BE0", Offset = "0x29D81E0", VA = "0x1829D9BE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector2 size, Color color)
		{
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x29D9DF0", Offset = "0x29D83F0", VA = "0x1829D9DF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector2 size, float cornerRadius)
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x29DA060", Offset = "0x29D8660", VA = "0x1829DA060")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector2 size, float cornerRadius, Color color)
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x29DA290", Offset = "0x29D8890", VA = "0x1829DA290")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector2 size, Vector4 cornerRadii)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x29DA500", Offset = "0x29D8B00", VA = "0x1829DA500")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector2 size, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x29DA720", Offset = "0x29D8D20", VA = "0x1829DA720")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, float width, float height)
		{
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x29DA970", Offset = "0x29D8F70", VA = "0x1829DA970")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, float width, float height, Color color)
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x29DAB90", Offset = "0x29D9190", VA = "0x1829DAB90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, float width, float height, float cornerRadius)
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x29DAE00", Offset = "0x29D9400", VA = "0x1829DAE00")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, float width, float height, float cornerRadius, Color color)
		{
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x29DB030", Offset = "0x29D9630", VA = "0x1829DB030")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, float width, float height, Vector4 cornerRadii)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x29DB290", Offset = "0x29D9890", VA = "0x1829DB290")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, float width, float height, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x29DB4C0", Offset = "0x29D9AC0", VA = "0x1829DB4C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Vector2 size)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x29DB960", Offset = "0x29D9F60", VA = "0x1829DB960")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Vector2 size, Color color)
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x29DBDD0", Offset = "0x29DA3D0", VA = "0x1829DBDD0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Vector2 size, float cornerRadius)
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x29DC290", Offset = "0x29DA890", VA = "0x1829DC290")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Vector2 size, float cornerRadius, Color color)
		{
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x29DC710", Offset = "0x29DAD10", VA = "0x1829DC710")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Vector2 size, Vector4 cornerRadii)
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x29DCBC0", Offset = "0x29DB1C0", VA = "0x1829DCBC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Vector2 size, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x29DD030", Offset = "0x29DB630", VA = "0x1829DD030")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, float width, float height)
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x29DD4F0", Offset = "0x29DBAF0", VA = "0x1829DD4F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, float width, float height, Color color)
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x29DD970", Offset = "0x29DBF70", VA = "0x1829DD970")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, float width, float height, float cornerRadius)
		{
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x29DDE40", Offset = "0x29DC440", VA = "0x1829DDE40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, float width, float height, float cornerRadius, Color color)
		{
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x29DE2C0", Offset = "0x29DC8C0", VA = "0x1829DE2C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, float width, float height, Vector4 cornerRadii)
		{
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x29DE780", Offset = "0x29DCD80", VA = "0x1829DE780")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, float width, float height, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x29DEC00", Offset = "0x29DD200", VA = "0x1829DEC00")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Vector2 size)
		{
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x29DF000", Offset = "0x29DD600", VA = "0x1829DF000")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Vector2 size, Color color)
		{
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x29DF3C0", Offset = "0x29DD9C0", VA = "0x1829DF3C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Vector2 size, float cornerRadius)
		{
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x29DF7D0", Offset = "0x29DDDD0", VA = "0x1829DF7D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Vector2 size, float cornerRadius, Color color)
		{
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x29DFBB0", Offset = "0x29DE1B0", VA = "0x1829DFBB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Vector2 size, Vector4 cornerRadii)
		{
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x29DFFC0", Offset = "0x29DE5C0", VA = "0x1829DFFC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Vector2 size, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x29E0390", Offset = "0x29DE990", VA = "0x1829E0390")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, float width, float height)
		{
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x29E07A0", Offset = "0x29DEDA0", VA = "0x1829E07A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, float width, float height, Color color)
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x29E0B80", Offset = "0x29DF180", VA = "0x1829E0B80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, float width, float height, float cornerRadius)
		{
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x29E0FA0", Offset = "0x29DF5A0", VA = "0x1829E0FA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, float width, float height, float cornerRadius, Color color)
		{
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x29E1390", Offset = "0x29DF990", VA = "0x1829E1390")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, float width, float height, Vector4 cornerRadii)
		{
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x29E17B0", Offset = "0x29DFDB0", VA = "0x1829E17B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, float width, float height, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x29E1B90", Offset = "0x29E0190", VA = "0x1829E1B90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Rect rect)
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x29E1D10", Offset = "0x29E0310", VA = "0x1829E1D10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Rect rect, Color color)
		{
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x29E1E40", Offset = "0x29E0440", VA = "0x1829E1E40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Rect rect, float cornerRadius)
		{
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x29E1FD0", Offset = "0x29E05D0", VA = "0x1829E1FD0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Rect rect, float cornerRadius, Color color)
		{
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x29E2120", Offset = "0x29E0720", VA = "0x1829E2120")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Rect rect, Vector4 cornerRadii)
		{
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x29E22A0", Offset = "0x29E08A0", VA = "0x1829E22A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Rect rect, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x29E23E0", Offset = "0x29E09E0", VA = "0x1829E23E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector2 size, RectPivot pivot)
		{
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x29E2670", Offset = "0x29E0C70", VA = "0x1829E2670")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector2 size, RectPivot pivot, Color color)
		{
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x29E28C0", Offset = "0x29E0EC0", VA = "0x1829E28C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector2 size, RectPivot pivot, float cornerRadius)
		{
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x29E2B70", Offset = "0x29E1170", VA = "0x1829E2B70")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector2 size, RectPivot pivot, float cornerRadius, Color color)
		{
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x29E2DC0", Offset = "0x29E13C0", VA = "0x1829E2DC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector2 size, RectPivot pivot, Vector4 cornerRadii)
		{
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x29E3060", Offset = "0x29E1660", VA = "0x1829E3060")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector2 size, RectPivot pivot, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x29E32B0", Offset = "0x29E18B0", VA = "0x1829E32B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, float width, float height, RectPivot pivot)
		{
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x29E3520", Offset = "0x29E1B20", VA = "0x1829E3520")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, float width, float height, RectPivot pivot, Color color)
		{
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x29E3760", Offset = "0x29E1D60", VA = "0x1829E3760")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, float width, float height, RectPivot pivot, float cornerRadius)
		{
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x29E39E0", Offset = "0x29E1FE0", VA = "0x1829E39E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, float width, float height, RectPivot pivot, float cornerRadius, Color color)
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x29E3C20", Offset = "0x29E2220", VA = "0x1829E3C20")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, float width, float height, RectPivot pivot, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x29E3EA0", Offset = "0x29E24A0", VA = "0x1829E3EA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, float width, float height, RectPivot pivot, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x29E40E0", Offset = "0x29E26E0", VA = "0x1829E40E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot)
		{
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x29E45B0", Offset = "0x29E2BB0", VA = "0x1829E45B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, Color color)
		{
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x29E4A50", Offset = "0x29E3050", VA = "0x1829E4A50")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, float cornerRadius)
		{
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x29E4F30", Offset = "0x29E3530", VA = "0x1829E4F30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, float cornerRadius, Color color)
		{
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x29E53E0", Offset = "0x29E39E0", VA = "0x1829E53E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x29E58C0", Offset = "0x29E3EC0", VA = "0x1829E58C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x29E5D60", Offset = "0x29E4360", VA = "0x1829E5D60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot)
		{
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x29E6230", Offset = "0x29E4830", VA = "0x1829E6230")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, Color color)
		{
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x29E66C0", Offset = "0x29E4CC0", VA = "0x1829E66C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, float cornerRadius)
		{
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x29E6BA0", Offset = "0x29E51A0", VA = "0x1829E6BA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, float cornerRadius, Color color)
		{
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x29E7040", Offset = "0x29E5640", VA = "0x1829E7040")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, Vector4 cornerRadii)
		{
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x29E7510", Offset = "0x29E5B10", VA = "0x1829E7510")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x29E79A0", Offset = "0x29E5FA0", VA = "0x1829E79A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot)
		{
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x29E7DD0", Offset = "0x29E63D0", VA = "0x1829E7DD0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, Color color)
		{
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x29E81C0", Offset = "0x29E67C0", VA = "0x1829E81C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, float cornerRadius)
		{
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x29E8600", Offset = "0x29E6C00", VA = "0x1829E8600")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, float cornerRadius, Color color)
		{
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x29E8A10", Offset = "0x29E7010", VA = "0x1829E8A10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x29E8E40", Offset = "0x29E7440", VA = "0x1829E8E40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x29E9240", Offset = "0x29E7840", VA = "0x1829E9240")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot)
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x29E9670", Offset = "0x29E7C70", VA = "0x1829E9670")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, Color color)
		{
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x29E9A60", Offset = "0x29E8060", VA = "0x1829E9A60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, float cornerRadius)
		{
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x29E9E90", Offset = "0x29E8490", VA = "0x1829E9E90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, float cornerRadius, Color color)
		{
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x29EA290", Offset = "0x29E8890", VA = "0x1829EA290")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, Vector4 cornerRadii)
		{
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x29EA6C0", Offset = "0x29E8CC0", VA = "0x1829EA6C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rectangle(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x29EAAB0", Offset = "0x29E90B0", VA = "0x1829EAAB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Rect rect, float thickness)
		{
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x29EAC80", Offset = "0x29E9280", VA = "0x1829EAC80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Rect rect, float thickness, Color color)
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x29EAE10", Offset = "0x29E9410", VA = "0x1829EAE10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Rect rect, float thickness, float cornerRadius)
		{
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x29EAFF0", Offset = "0x29E95F0", VA = "0x1829EAFF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Rect rect, float thickness, float cornerRadius, Color color)
		{
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x29EB1A0", Offset = "0x29E97A0", VA = "0x1829EB1A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Rect rect, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x29EB370", Offset = "0x29E9970", VA = "0x1829EB370")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Rect rect, float thickness, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x29EB510", Offset = "0x29E9B10", VA = "0x1829EB510")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Rect rect, float thickness)
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x29EB940", Offset = "0x29E9F40", VA = "0x1829EB940")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Rect rect, float thickness, Color color)
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x29EBD30", Offset = "0x29EA330", VA = "0x1829EBD30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Rect rect, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x29EC160", Offset = "0x29EA760", VA = "0x1829EC160")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Rect rect, float thickness, float cornerRadius, Color color)
		{
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x29EC560", Offset = "0x29EAB60", VA = "0x1829EC560")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Rect rect, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x29EC990", Offset = "0x29EAF90", VA = "0x1829EC990")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Rect rect, float thickness, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x29ECD80", Offset = "0x29EB380", VA = "0x1829ECD80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Rect rect, float thickness)
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x29ED100", Offset = "0x29EB700", VA = "0x1829ED100")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Rect rect, float thickness, Color color)
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x29ED450", Offset = "0x29EBA50", VA = "0x1829ED450")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Rect rect, float thickness, float cornerRadius)
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x29ED7E0", Offset = "0x29EBDE0", VA = "0x1829ED7E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Rect rect, float thickness, float cornerRadius, Color color)
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x29EDB30", Offset = "0x29EC130", VA = "0x1829EDB30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Rect rect, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x29EDEC0", Offset = "0x29EC4C0", VA = "0x1829EDEC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Rect rect, float thickness, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x29EE210", Offset = "0x29EC810", VA = "0x1829EE210")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector2 size, float thickness)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x29EE420", Offset = "0x29ECA20", VA = "0x1829EE420")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector2 size, float thickness, Color color)
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x29EE600", Offset = "0x29ECC00", VA = "0x1829EE600")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector2 size, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x29EE830", Offset = "0x29ECE30", VA = "0x1829EE830")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector2 size, float thickness, float cornerRadius, Color color)
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x29EEA20", Offset = "0x29ED020", VA = "0x1829EEA20")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector2 size, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x29EEC40", Offset = "0x29ED240", VA = "0x1829EEC40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector2 size, float thickness, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x29EEE30", Offset = "0x29ED430", VA = "0x1829EEE30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, float width, float height, float thickness)
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x29EF050", Offset = "0x29ED650", VA = "0x1829EF050")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, float width, float height, float thickness, Color color)
		{
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x29EF230", Offset = "0x29ED830", VA = "0x1829EF230")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, float width, float height, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x29EF450", Offset = "0x29EDA50", VA = "0x1829EF450")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, float width, float height, float thickness, float cornerRadius, Color color)
		{
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x29EF640", Offset = "0x29EDC40", VA = "0x1829EF640")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, float width, float height, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x29EF860", Offset = "0x29EDE60", VA = "0x1829EF860")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, float width, float height, float thickness, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x29EFA50", Offset = "0x29EE050", VA = "0x1829EFA50")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Vector2 size, float thickness)
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x29EFEC0", Offset = "0x29EE4C0", VA = "0x1829EFEC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Vector2 size, float thickness, Color color)
		{
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x29F02F0", Offset = "0x29EE8F0", VA = "0x1829F02F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Vector2 size, float thickness, float cornerRadius)
		{
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x29F0760", Offset = "0x29EED60", VA = "0x1829F0760")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Vector2 size, float thickness, float cornerRadius, Color color)
		{
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x29F0BA0", Offset = "0x29EF1A0", VA = "0x1829F0BA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Vector2 size, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x29F1010", Offset = "0x29EF610", VA = "0x1829F1010")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Vector2 size, float thickness, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x29F1450", Offset = "0x29EFA50", VA = "0x1829F1450")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, float width, float height, float thickness)
		{
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x29F18D0", Offset = "0x29EFED0", VA = "0x1829F18D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, float width, float height, float thickness, Color color)
		{
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x29F1D10", Offset = "0x29F0310", VA = "0x1829F1D10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, float width, float height, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x29F2190", Offset = "0x29F0790", VA = "0x1829F2190")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, float width, float height, float thickness, float cornerRadius, Color color)
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x29F25D0", Offset = "0x29F0BD0", VA = "0x1829F25D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, float width, float height, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x29F2A50", Offset = "0x29F1050", VA = "0x1829F2A50")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, float width, float height, float thickness, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x29F2E90", Offset = "0x29F1490", VA = "0x1829F2E90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Vector2 size, float thickness)
		{
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x29F3260", Offset = "0x29F1860", VA = "0x1829F3260")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Vector2 size, float thickness, Color color)
		{
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x29F35F0", Offset = "0x29F1BF0", VA = "0x1829F35F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Vector2 size, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x29F39C0", Offset = "0x29F1FC0", VA = "0x1829F39C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Vector2 size, float thickness, float cornerRadius, Color color)
		{
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x29F3D60", Offset = "0x29F2360", VA = "0x1829F3D60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Vector2 size, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x29F4130", Offset = "0x29F2730", VA = "0x1829F4130")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Vector2 size, float thickness, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x29F44C0", Offset = "0x29F2AC0", VA = "0x1829F44C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, float width, float height, float thickness)
		{
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x29F4890", Offset = "0x29F2E90", VA = "0x1829F4890")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, float width, float height, float thickness, Color color)
		{
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x29F4C30", Offset = "0x29F3230", VA = "0x1829F4C30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, float width, float height, float thickness, float cornerRadius)
		{
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x29F5010", Offset = "0x29F3610", VA = "0x1829F5010")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, float width, float height, float thickness, float cornerRadius, Color color)
		{
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x29F53B0", Offset = "0x29F39B0", VA = "0x1829F53B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, float width, float height, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x29F5790", Offset = "0x29F3D90", VA = "0x1829F5790")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, float width, float height, float thickness, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x29F5B30", Offset = "0x29F4130", VA = "0x1829F5B30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Rect rect, float thickness)
		{
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x29F5C60", Offset = "0x29F4260", VA = "0x1829F5C60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Rect rect, float thickness, Color color)
		{
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x29F5D50", Offset = "0x29F4350", VA = "0x1829F5D50")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Rect rect, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x29F5E90", Offset = "0x29F4490", VA = "0x1829F5E90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Rect rect, float thickness, float cornerRadius, Color color)
		{
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x29F5FA0", Offset = "0x29F45A0", VA = "0x1829F5FA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Rect rect, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x29F60E0", Offset = "0x29F46E0", VA = "0x1829F60E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Rect rect, float thickness, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x29F61E0", Offset = "0x29F47E0", VA = "0x1829F61E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector2 size, RectPivot pivot, float thickness)
		{
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x29F6430", Offset = "0x29F4A30", VA = "0x1829F6430")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector2 size, RectPivot pivot, float thickness, Color color)
		{
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x29F6640", Offset = "0x29F4C40", VA = "0x1829F6640")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector2 size, RectPivot pivot, float thickness, float cornerRadius)
		{
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x29F6880", Offset = "0x29F4E80", VA = "0x1829F6880")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector2 size, RectPivot pivot, float thickness, float cornerRadius, Color color)
		{
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x29F6A80", Offset = "0x29F5080", VA = "0x1829F6A80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector2 size, RectPivot pivot, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x29F6CE0", Offset = "0x29F52E0", VA = "0x1829F6CE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector2 size, RectPivot pivot, float thickness, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x29F6F00", Offset = "0x29F5500", VA = "0x1829F6F00")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, float width, float height, RectPivot pivot, float thickness)
		{
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x29F7130", Offset = "0x29F5730", VA = "0x1829F7130")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, float width, float height, RectPivot pivot, float thickness, Color color)
		{
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x29F7330", Offset = "0x29F5930", VA = "0x1829F7330")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, float width, float height, RectPivot pivot, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x29F7570", Offset = "0x29F5B70", VA = "0x1829F7570")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, float width, float height, RectPivot pivot, float thickness, float cornerRadius, Color color)
		{
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x29F7780", Offset = "0x29F5D80", VA = "0x1829F7780")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, float width, float height, RectPivot pivot, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x29F79C0", Offset = "0x29F5FC0", VA = "0x1829F79C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, float width, float height, RectPivot pivot, float thickness, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x29F7BC0", Offset = "0x29F61C0", VA = "0x1829F7BC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, float thickness)
		{
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x29F8050", Offset = "0x29F6650", VA = "0x1829F8050")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, float thickness, Color color)
		{
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x29F84B0", Offset = "0x29F6AB0", VA = "0x1829F84B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x29F8950", Offset = "0x29F6F50", VA = "0x1829F8950")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, float thickness, float cornerRadius, Color color)
		{
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x29F8DB0", Offset = "0x29F73B0", VA = "0x1829F8DB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x29F9250", Offset = "0x29F7850", VA = "0x1829F9250")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, float thickness, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x29F96B0", Offset = "0x29F7CB0", VA = "0x1829F96B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, float thickness)
		{
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x29F9B40", Offset = "0x29F8140", VA = "0x1829F9B40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, float thickness, Color color)
		{
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x29F9F90", Offset = "0x29F8590", VA = "0x1829F9F90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, float thickness, float cornerRadius)
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x29FA420", Offset = "0x29F8A20", VA = "0x1829FA420")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, float thickness, float cornerRadius, Color color)
		{
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x29FA880", Offset = "0x29F8E80", VA = "0x1829FA880")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x29FAD10", Offset = "0x29F9310", VA = "0x1829FAD10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, float thickness, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x29FB170", Offset = "0x29F9770", VA = "0x1829FB170")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, float thickness)
		{
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x29FB560", Offset = "0x29F9B60", VA = "0x1829FB560")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, float thickness, Color color)
		{
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x29FB910", Offset = "0x29F9F10", VA = "0x1829FB910")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x29FBD10", Offset = "0x29FA310", VA = "0x1829FBD10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, float thickness, float cornerRadius, Color color)
		{
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x29FC0D0", Offset = "0x29FA6D0", VA = "0x1829FC0D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x29FC4C0", Offset = "0x29FAAC0", VA = "0x1829FC4C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, float thickness, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x29FC880", Offset = "0x29FAE80", VA = "0x1829FC880")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, float thickness)
		{
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x29FCC70", Offset = "0x29FB270", VA = "0x1829FCC70")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, float thickness, Color color)
		{
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x29FD020", Offset = "0x29FB620", VA = "0x1829FD020")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x29FD410", Offset = "0x29FBA10", VA = "0x1829FD410")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, float thickness, float cornerRadius, Color color)
		{
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x29FD7C0", Offset = "0x29FBDC0", VA = "0x1829FD7C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x29FDBB0", Offset = "0x29FC1B0", VA = "0x1829FDBB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectangleBorder(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, float thickness, Vector4 cornerRadii, Color color)
		{
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x29FDF60", Offset = "0x29FC560", VA = "0x1829FDF60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Triangle(Vector3 a, Vector3 b, Vector3 c)
		{
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x29FE1B0", Offset = "0x29FC7B0", VA = "0x1829FE1B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Triangle(Vector3 a, Vector3 b, Vector3 c, Color color)
		{
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x29FE310", Offset = "0x29FC910", VA = "0x1829FE310")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Triangle(Vector3 a, Vector3 b, Vector3 c, Color colorA, Color colorB, Color colorC)
		{
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x29FE480", Offset = "0x29FCA80", VA = "0x1829FE480")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Triangle(Vector3 a, Vector3 b, Vector3 c, float roundness)
		{
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x29FE6E0", Offset = "0x29FCCE0", VA = "0x1829FE6E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Triangle(Vector3 a, Vector3 b, Vector3 c, float roundness, Color color)
		{
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x29FE850", Offset = "0x29FCE50", VA = "0x1829FE850")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Triangle(Vector3 a, Vector3 b, Vector3 c, float roundness, Color colorA, Color colorB, Color colorC)
		{
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x29FE9D0", Offset = "0x29FCFD0", VA = "0x1829FE9D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TriangleBorder(Vector3 a, Vector3 b, Vector3 c)
		{
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x29FEC20", Offset = "0x29FD220", VA = "0x1829FEC20")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TriangleBorder(Vector3 a, Vector3 b, Vector3 c, Color color)
		{
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x29FED80", Offset = "0x29FD380", VA = "0x1829FED80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TriangleBorder(Vector3 a, Vector3 b, Vector3 c, Color colorA, Color colorB, Color colorC)
		{
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x29FEEF0", Offset = "0x29FD4F0", VA = "0x1829FEEF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TriangleBorder(Vector3 a, Vector3 b, Vector3 c, float thickness)
		{
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x29FF100", Offset = "0x29FD700", VA = "0x1829FF100")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TriangleBorder(Vector3 a, Vector3 b, Vector3 c, float thickness, Color color)
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x29FF220", Offset = "0x29FD820", VA = "0x1829FF220")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TriangleBorder(Vector3 a, Vector3 b, Vector3 c, float thickness, Color colorA, Color colorB, Color colorC)
		{
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x29FF360", Offset = "0x29FD960", VA = "0x1829FF360")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TriangleBorder(Vector3 a, Vector3 b, Vector3 c, float thickness, float roundness)
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x29FF570", Offset = "0x29FDB70", VA = "0x1829FF570")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TriangleBorder(Vector3 a, Vector3 b, Vector3 c, float thickness, float roundness, Color color)
		{
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x29FF6A0", Offset = "0x29FDCA0", VA = "0x1829FF6A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TriangleBorder(Vector3 a, Vector3 b, Vector3 c, float thickness, float roundness, Color colorA, Color colorB, Color colorC)
		{
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x29FF7E0", Offset = "0x29FDDE0", VA = "0x1829FF7E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Quad(Vector3 a, Vector3 b, Vector3 c)
		{
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x29FFAB0", Offset = "0x29FE0B0", VA = "0x1829FFAB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Quad(Vector3 a, Vector3 b, Vector3 c, Color color)
		{
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x29FFC40", Offset = "0x29FE240", VA = "0x1829FFC40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Quad(Vector3 a, Vector3 b, Vector3 c, Color colorA, Color colorB, Color colorC, Color colorD)
		{
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x29FFDE0", Offset = "0x29FE3E0", VA = "0x1829FFDE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Quad(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x2A00070", Offset = "0x29FE670", VA = "0x182A00070")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Quad(Vector3 a, Vector3 b, Vector3 c, Vector3 d, Color color)
		{
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x2A001B0", Offset = "0x29FE7B0", VA = "0x182A001B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Quad(Vector3 a, Vector3 b, Vector3 c, Vector3 d, Color colorA, Color colorB, Color colorC, Color colorD)
		{
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x2A00310", Offset = "0x29FE910", VA = "0x182A00310")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Sphere(Vector3 pos)
		{
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x2A004A0", Offset = "0x29FEAA0", VA = "0x182A004A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Sphere(Vector3 pos, float radius)
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x2A005E0", Offset = "0x29FEBE0", VA = "0x182A005E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Sphere(Vector3 pos, Color color)
		{
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x2A00720", Offset = "0x29FED20", VA = "0x182A00720")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Sphere(Vector3 pos, float radius, Color color)
		{
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x2A00830", Offset = "0x29FEE30", VA = "0x182A00830")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Sphere()
		{
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x2A00920", Offset = "0x29FEF20", VA = "0x182A00920")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Sphere(float radius)
		{
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x2A009D0", Offset = "0x29FEFD0", VA = "0x182A009D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Sphere(Color color)
		{
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x2A00A70", Offset = "0x29FF070", VA = "0x182A00A70")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Sphere(float radius, Color color)
		{
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x2A00AE0", Offset = "0x29FF0E0", VA = "0x182A00AE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cuboid(Vector3 pos, Vector3 size)
		{
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x2A00C40", Offset = "0x29FF240", VA = "0x182A00C40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cuboid(Vector3 pos, Vector3 size, Color color)
		{
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x2A00D60", Offset = "0x29FF360", VA = "0x182A00D60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cuboid(Vector3 pos, Vector3 normal, Vector3 size)
		{
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x2A01120", Offset = "0x29FF720", VA = "0x182A01120")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cuboid(Vector3 pos, Vector3 normal, Vector3 size, Color color)
		{
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x2A014B0", Offset = "0x29FFAB0", VA = "0x182A014B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cuboid(Vector3 pos, Quaternion rot, Vector3 size)
		{
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x2A017E0", Offset = "0x29FFDE0", VA = "0x182A017E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cuboid(Vector3 pos, Quaternion rot, Vector3 size, Color color)
		{
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x2A01AE0", Offset = "0x2A000E0", VA = "0x182A01AE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cuboid(Vector3 size)
		{
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x2A01B90", Offset = "0x2A00190", VA = "0x182A01B90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cuboid(Vector3 size, Color color)
		{
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x2A01C10", Offset = "0x2A00210", VA = "0x182A01C10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cube(Vector3 pos, float size)
		{
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x2A01D80", Offset = "0x2A00380", VA = "0x182A01D80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cube(Vector3 pos, float size, Color color)
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x2A01EB0", Offset = "0x2A004B0", VA = "0x182A01EB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cube(Vector3 pos, Vector3 normal, float size)
		{
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2A02290", Offset = "0x2A00890", VA = "0x182A02290")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cube(Vector3 pos, Vector3 normal, float size, Color color)
		{
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x2A02630", Offset = "0x2A00C30", VA = "0x182A02630")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cube(Vector3 pos, Quaternion rot, float size)
		{
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x2A02970", Offset = "0x2A00F70", VA = "0x182A02970")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cube(Vector3 pos, Quaternion rot, float size, Color color)
		{
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x2A02C60", Offset = "0x2A01260", VA = "0x182A02C60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cube(float size)
		{
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x2A02D30", Offset = "0x2A01330", VA = "0x182A02D30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cube(float size, Color color)
		{
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x2A02DC0", Offset = "0x2A013C0", VA = "0x182A02DC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cone(Vector3 pos, float radius, float length)
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x2A02F20", Offset = "0x2A01520", VA = "0x182A02F20")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cone(Vector3 pos, float radius, float length, bool fillCap)
		{
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x2A03090", Offset = "0x2A01690", VA = "0x182A03090")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cone(Vector3 pos, float radius, float length, Color color)
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2A031B0", Offset = "0x2A017B0", VA = "0x182A031B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cone(Vector3 pos, float radius, float length, bool fillCap, Color color)
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x2A032E0", Offset = "0x2A018E0", VA = "0x182A032E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cone(Vector3 pos, Vector3 normal, float radius, float length)
		{
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x2A036B0", Offset = "0x2A01CB0", VA = "0x182A036B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cone(Vector3 pos, Vector3 normal, float radius, float length, bool fillCap)
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x2A03A80", Offset = "0x2A02080", VA = "0x182A03A80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cone(Vector3 pos, Vector3 normal, float radius, float length, Color color)
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x2A03E10", Offset = "0x2A02410", VA = "0x182A03E10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cone(Vector3 pos, Vector3 normal, float radius, float length, bool fillCap, Color color)
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x2A041A0", Offset = "0x2A027A0", VA = "0x182A041A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cone(Vector3 pos, Quaternion rot, float radius, float length)
		{
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x2A044D0", Offset = "0x2A02AD0", VA = "0x182A044D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cone(Vector3 pos, Quaternion rot, float radius, float length, bool fillCap)
		{
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x2A04800", Offset = "0x2A02E00", VA = "0x182A04800")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cone(Vector3 pos, Quaternion rot, float radius, float length, Color color)
		{
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x2A04AF0", Offset = "0x2A030F0", VA = "0x182A04AF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cone(Vector3 pos, Quaternion rot, float radius, float length, bool fillCap, Color color)
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x2A04DE0", Offset = "0x2A033E0", VA = "0x182A04DE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cone(float radius, float length)
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x2A04EA0", Offset = "0x2A034A0", VA = "0x182A04EA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cone(float radius, float length, bool fillCap)
		{
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x2A04F70", Offset = "0x2A03570", VA = "0x182A04F70")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cone(float radius, float length, Color color)
		{
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x2A04FF0", Offset = "0x2A035F0", VA = "0x182A04FF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cone(float radius, float length, bool fillCap, Color color)
		{
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x2A05080", Offset = "0x2A03680", VA = "0x182A05080")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Torus(Vector3 pos, float radius, float thickness)
		{
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x2A051F0", Offset = "0x2A037F0", VA = "0x182A051F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Torus(Vector3 pos, float radius, float thickness, Color color)
		{
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x2A05320", Offset = "0x2A03920", VA = "0x182A05320")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Torus(Vector3 pos, Vector3 normal, float radius, float thickness)
		{
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x2A05700", Offset = "0x2A03D00", VA = "0x182A05700")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Torus(Vector3 pos, Vector3 normal, float radius, float thickness, Color color)
		{
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x2A05AA0", Offset = "0x2A040A0", VA = "0x182A05AA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Torus(Vector3 pos, Quaternion rot, float radius, float thickness)
		{
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x2A05DE0", Offset = "0x2A043E0", VA = "0x182A05DE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Torus(Vector3 pos, Quaternion rot, float radius, float thickness, Color color)
		{
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2A060E0", Offset = "0x2A046E0", VA = "0x182A060E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Torus(float radius, float thickness)
		{
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x2A061B0", Offset = "0x2A047B0", VA = "0x182A061B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Torus(float radius, float thickness, Color color)
		{
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2A06240", Offset = "0x2A04840", VA = "0x182A06240")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Torus(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x2A063B0", Offset = "0x2A049B0", VA = "0x182A063B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Torus(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2A064E0", Offset = "0x2A04AE0", VA = "0x182A064E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Torus(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2A068C0", Offset = "0x2A04EC0", VA = "0x182A068C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Torus(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2A06C60", Offset = "0x2A05260", VA = "0x182A06C60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Torus(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2A06FA0", Offset = "0x2A055A0", VA = "0x182A06FA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Torus(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2A072A0", Offset = "0x2A058A0", VA = "0x182A072A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Torus(float radius, float thickness, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x2A07370", Offset = "0x2A05970", VA = "0x182A07370")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Torus(float radius, float thickness, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x2A07400", Offset = "0x2A05A00", VA = "0x182A07400")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, string content)
		{
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x2A07640", Offset = "0x2A05C40", VA = "0x182A07640")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, string content, TextAlign align)
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x2A07840", Offset = "0x2A05E40", VA = "0x182A07840")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, string content, float fontSize)
		{
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x2A07A40", Offset = "0x2A06040", VA = "0x182A07A40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, string content, TextAlign align, float fontSize)
		{
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x2A07BF0", Offset = "0x2A061F0", VA = "0x182A07BF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, string content, TMP_FontAsset font)
		{
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x2A07DF0", Offset = "0x2A063F0", VA = "0x182A07DF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, string content, TextAlign align, TMP_FontAsset font)
		{
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2A07FB0", Offset = "0x2A065B0", VA = "0x182A07FB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, string content, float fontSize, TMP_FontAsset font)
		{
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x2A08160", Offset = "0x2A06760", VA = "0x182A08160")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, string content, TextAlign align, float fontSize, TMP_FontAsset font)
		{
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x2A082E0", Offset = "0x2A068E0", VA = "0x182A082E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, string content, Color color)
		{
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x2A084E0", Offset = "0x2A06AE0", VA = "0x182A084E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, string content, TextAlign align, Color color)
		{
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x2A086A0", Offset = "0x2A06CA0", VA = "0x182A086A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, string content, float fontSize, Color color)
		{
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x2A08850", Offset = "0x2A06E50", VA = "0x182A08850")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, string content, TextAlign align, float fontSize, Color color)
		{
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x2A089D0", Offset = "0x2A06FD0", VA = "0x182A089D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, string content, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x2A08B90", Offset = "0x2A07190", VA = "0x182A08B90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, string content, TextAlign align, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x2A08D00", Offset = "0x2A07300", VA = "0x182A08D00")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, string content, float fontSize, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x2A08E80", Offset = "0x2A07480", VA = "0x182A08E80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, string content, TextAlign align, float fontSize, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x2A08FC0", Offset = "0x2A075C0", VA = "0x182A08FC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Vector3 normal, string content)
		{
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x2A09450", Offset = "0x2A07A50", VA = "0x182A09450")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Vector3 normal, string content, TextAlign align)
		{
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x2A098B0", Offset = "0x2A07EB0", VA = "0x182A098B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Vector3 normal, string content, float fontSize)
		{
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x2A09D10", Offset = "0x2A08310", VA = "0x182A09D10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Vector3 normal, string content, TextAlign align, float fontSize)
		{
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x2A0A120", Offset = "0x2A08720", VA = "0x182A0A120")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Vector3 normal, string content, TMP_FontAsset font)
		{
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x2A0A570", Offset = "0x2A08B70", VA = "0x182A0A570")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Vector3 normal, string content, TextAlign align, TMP_FontAsset font)
		{
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x2A0A980", Offset = "0x2A08F80", VA = "0x182A0A980")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Vector3 normal, string content, float fontSize, TMP_FontAsset font)
		{
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x2A0ADA0", Offset = "0x2A093A0", VA = "0x182A0ADA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Vector3 normal, string content, TextAlign align, float fontSize, TMP_FontAsset font)
		{
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x2A0B170", Offset = "0x2A09770", VA = "0x182A0B170")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Vector3 normal, string content, Color color)
		{
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x2A0B5D0", Offset = "0x2A09BD0", VA = "0x182A0B5D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Vector3 normal, string content, TextAlign align, Color color)
		{
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x2A0B9F0", Offset = "0x2A09FF0", VA = "0x182A0B9F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Vector3 normal, string content, float fontSize, Color color)
		{
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x2A0BE10", Offset = "0x2A0A410", VA = "0x182A0BE10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Vector3 normal, string content, TextAlign align, float fontSize, Color color)
		{
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x2A0C1F0", Offset = "0x2A0A7F0", VA = "0x182A0C1F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Vector3 normal, string content, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x2A0C610", Offset = "0x2A0AC10", VA = "0x182A0C610")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Vector3 normal, string content, TextAlign align, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x2A0C9E0", Offset = "0x2A0AFE0", VA = "0x182A0C9E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Vector3 normal, string content, float fontSize, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2A0CDC0", Offset = "0x2A0B3C0", VA = "0x182A0CDC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Vector3 normal, string content, TextAlign align, float fontSize, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x2A0D160", Offset = "0x2A0B760", VA = "0x182A0D160")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Quaternion rot, string content)
		{
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x2A0D550", Offset = "0x2A0BB50", VA = "0x182A0D550")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Quaternion rot, string content, TextAlign align)
		{
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2A0D900", Offset = "0x2A0BF00", VA = "0x182A0D900")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Quaternion rot, string content, float fontSize)
		{
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2A0DCB0", Offset = "0x2A0C2B0", VA = "0x182A0DCB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Quaternion rot, string content, TextAlign align, float fontSize)
		{
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x2A0E020", Offset = "0x2A0C620", VA = "0x182A0E020")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Quaternion rot, string content, TMP_FontAsset font)
		{
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2A0E3D0", Offset = "0x2A0C9D0", VA = "0x182A0E3D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Quaternion rot, string content, TextAlign align, TMP_FontAsset font)
		{
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2A0E740", Offset = "0x2A0CD40", VA = "0x182A0E740")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Quaternion rot, string content, float fontSize, TMP_FontAsset font)
		{
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x2A0EAB0", Offset = "0x2A0D0B0", VA = "0x182A0EAB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Quaternion rot, string content, TextAlign align, float fontSize, TMP_FontAsset font)
		{
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x2A0EDE0", Offset = "0x2A0D3E0", VA = "0x182A0EDE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Quaternion rot, string content, Color color)
		{
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x2A0F190", Offset = "0x2A0D790", VA = "0x182A0F190")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Quaternion rot, string content, TextAlign align, Color color)
		{
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2A0F500", Offset = "0x2A0DB00", VA = "0x182A0F500")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Quaternion rot, string content, float fontSize, Color color)
		{
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2A0F880", Offset = "0x2A0DE80", VA = "0x182A0F880")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Quaternion rot, string content, TextAlign align, float fontSize, Color color)
		{
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x2A0FBB0", Offset = "0x2A0E1B0", VA = "0x182A0FBB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Quaternion rot, string content, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x2A0FF20", Offset = "0x2A0E520", VA = "0x182A0FF20")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Quaternion rot, string content, TextAlign align, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2A10250", Offset = "0x2A0E850", VA = "0x182A10250")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Quaternion rot, string content, float fontSize, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2A10580", Offset = "0x2A0EB80", VA = "0x182A10580")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, Quaternion rot, string content, TextAlign align, float fontSize, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x2A10870", Offset = "0x2A0EE70", VA = "0x182A10870")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, float angle, string content)
		{
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2A10AC0", Offset = "0x2A0F0C0", VA = "0x182A10AC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, float angle, string content, TextAlign align)
		{
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2A10CC0", Offset = "0x2A0F2C0", VA = "0x182A10CC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, float angle, string content, float fontSize)
		{
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2A10ED0", Offset = "0x2A0F4D0", VA = "0x182A10ED0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, float angle, string content, TextAlign align, float fontSize)
		{
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2A11090", Offset = "0x2A0F690", VA = "0x182A11090")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, float angle, string content, TMP_FontAsset font)
		{
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2A11290", Offset = "0x2A0F890", VA = "0x182A11290")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, float angle, string content, TextAlign align, TMP_FontAsset font)
		{
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2A11450", Offset = "0x2A0FA50", VA = "0x182A11450")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, float angle, string content, float fontSize, TMP_FontAsset font)
		{
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2A11610", Offset = "0x2A0FC10", VA = "0x182A11610")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, float angle, string content, TextAlign align, float fontSize, TMP_FontAsset font)
		{
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2A11790", Offset = "0x2A0FD90", VA = "0x182A11790")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, float angle, string content, Color color)
		{
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2A11990", Offset = "0x2A0FF90", VA = "0x182A11990")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, float angle, string content, TextAlign align, Color color)
		{
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2A11B60", Offset = "0x2A10160", VA = "0x182A11B60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, float angle, string content, float fontSize, Color color)
		{
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2A11D20", Offset = "0x2A10320", VA = "0x182A11D20")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, float angle, string content, TextAlign align, float fontSize, Color color)
		{
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2A11EB0", Offset = "0x2A104B0", VA = "0x182A11EB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, float angle, string content, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2A12080", Offset = "0x2A10680", VA = "0x182A12080")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, float angle, string content, TextAlign align, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2A12200", Offset = "0x2A10800", VA = "0x182A12200")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, float angle, string content, float fontSize, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2A12380", Offset = "0x2A10980", VA = "0x182A12380")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(Vector3 pos, float angle, string content, TextAlign align, float fontSize, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2A124D0", Offset = "0x2A10AD0", VA = "0x182A124D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(string content)
		{
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2A12670", Offset = "0x2A10C70", VA = "0x182A12670")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(string content, TextAlign align)
		{
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x2A127D0", Offset = "0x2A10DD0", VA = "0x182A127D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(string content, float fontSize)
		{
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x2A12930", Offset = "0x2A10F30", VA = "0x182A12930")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(string content, TextAlign align, float fontSize)
		{
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2A12A50", Offset = "0x2A11050", VA = "0x182A12A50")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(string content, TMP_FontAsset font)
		{
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2A12BB0", Offset = "0x2A111B0", VA = "0x182A12BB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(string content, TextAlign align, TMP_FontAsset font)
		{
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2A12CD0", Offset = "0x2A112D0", VA = "0x182A12CD0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(string content, float fontSize, TMP_FontAsset font)
		{
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2A12DF0", Offset = "0x2A113F0", VA = "0x182A12DF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(string content, TextAlign align, float fontSize, TMP_FontAsset font)
		{
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2A12ED0", Offset = "0x2A114D0", VA = "0x182A12ED0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(string content, Color color)
		{
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2A13030", Offset = "0x2A11630", VA = "0x182A13030")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(string content, TextAlign align, Color color)
		{
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2A13150", Offset = "0x2A11750", VA = "0x182A13150")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(string content, float fontSize, Color color)
		{
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x2A13270", Offset = "0x2A11870", VA = "0x182A13270")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(string content, TextAlign align, float fontSize, Color color)
		{
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x2A13350", Offset = "0x2A11950", VA = "0x182A13350")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(string content, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x2A13470", Offset = "0x2A11A70", VA = "0x182A13470")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(string content, TextAlign align, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x2A13550", Offset = "0x2A11B50", VA = "0x182A13550")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(string content, float fontSize, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x2A13630", Offset = "0x2A11C30", VA = "0x182A13630")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(string content, TextAlign align, float fontSize, TMP_FontAsset font, Color color)
		{
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x2A136D0", Offset = "0x2A11CD0", VA = "0x182A136D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Texture(Texture texture, Rect rect, Rect uvs)
		{
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x2A137B0", Offset = "0x2A11DB0", VA = "0x182A137B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Texture(Texture texture, Rect rect, Rect uvs, Color color)
		{
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x2A13860", Offset = "0x2A11E60", VA = "0x182A13860")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Texture(Texture texture, Rect rect)
		{
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x2A13920", Offset = "0x2A11F20", VA = "0x182A13920")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Texture(Texture texture, Rect rect, Color color)
		{
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x2A139B0", Offset = "0x2A11FB0", VA = "0x182A139B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Texture(Texture texture, Rect rect, TextureFillMode fillMode)
		{
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x2A13A80", Offset = "0x2A12080", VA = "0x182A13A80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Texture(Texture texture, Rect rect, TextureFillMode fillMode, Color color)
		{
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x2A13B10", Offset = "0x2A12110", VA = "0x182A13B10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Texture(Texture texture, Vector2 center, float size)
		{
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x2A13BE0", Offset = "0x2A121E0", VA = "0x182A13BE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Texture(Texture texture, Vector2 center, float size, Color color)
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x2A13C70", Offset = "0x2A12270", VA = "0x182A13C70")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Texture(Texture texture, Vector2 center, float size, TextureSizeMode sizeMode)
		{
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x2A13D40", Offset = "0x2A12340", VA = "0x182A13D40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Texture(Texture texture, Vector2 center, float size, TextureSizeMode sizeMode, Color color)
		{
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end)
		{
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, Color color)
		{
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, float thickness)
		{
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, float thickness, Color color)
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, float thickness, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, LineEndCap endCaps)
		{
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, LineEndCap endCaps, Color color)
		{
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, LineEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, float thickness, LineEndCap endCaps)
		{
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, float thickness, LineEndCap endCaps, Color color)
		{
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, float thickness, LineEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, DashStyle dashStyle)
		{
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, DashStyle dashStyle, Color color)
		{
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, DashStyle dashStyle, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, DashStyle dashStyle, float thickness)
		{
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, DashStyle dashStyle, float thickness, Color color)
		{
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, DashStyle dashStyle, float thickness, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, DashStyle dashStyle, LineEndCap endCaps)
		{
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, DashStyle dashStyle, LineEndCap endCaps, Color color)
		{
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, DashStyle dashStyle, LineEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, DashStyle dashStyle, float thickness, LineEndCap endCaps)
		{
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, DashStyle dashStyle, float thickness, LineEndCap endCaps, Color color)
		{
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void LineDashed(Vector3 start, Vector3 end, DashStyle dashStyle, float thickness, LineEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void PolygonFill(PolygonPath path)
		{
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void PolygonFill(PolygonPath path, GradientFill fill)
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void PolygonFill(PolygonPath path, PolygonTriangulation triangulation)
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void PolygonFill(PolygonPath path, PolygonTriangulation triangulation, GradientFill fill)
		{
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void PolygonFillLinear(PolygonPath path, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void PolygonFillLinear(PolygonPath path, PolygonTriangulation triangulation, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void PolygonFillRadial(PolygonPath path, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void PolygonFillRadial(PolygonPath path, PolygonTriangulation triangulation, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos)
		{
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Color color)
		{
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, float radius)
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, float radius, Color color)
		{
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, float radius, float thickness)
		{
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, float radius, float thickness, Color color)
		{
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, float radius, float thickness, float angle)
		{
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, float radius, float thickness, float angle, Color color)
		{
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, float radius, float thickness, float angle, float roundness, Color color)
		{
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, int sideCount)
		{
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, int sideCount, Color color)
		{
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, int sideCount, float radius)
		{
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, int sideCount, float radius, Color color)
		{
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, int sideCount, float radius, float thickness)
		{
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, int sideCount, float radius, float thickness, Color color)
		{
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, int sideCount, float radius, float thickness, float angle)
		{
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, int sideCount, float radius, float thickness, float angle, Color color)
		{
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, int sideCount, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, int sideCount, float radius, float thickness, float angle, float roundness, Color color)
		{
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal)
		{
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, Color color)
		{
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, float radius)
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, float radius, Color color)
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, float radius, float thickness)
		{
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, float radius, float thickness, Color color)
		{
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, float radius, float thickness, float angle)
		{
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, float radius, float thickness, float angle, Color color)
		{
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, float radius, float thickness, float angle, float roundness, Color color)
		{
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, int sideCount)
		{
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, int sideCount, Color color)
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, int sideCount, float radius)
		{
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, int sideCount, float radius, Color color)
		{
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness)
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, Color color)
		{
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, float angle)
		{
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, float angle, Color color)
		{
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, float angle, float roundness, Color color)
		{
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, Color color)
		{
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, float radius)
		{
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, float radius, Color color)
		{
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, float radius, float thickness)
		{
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, float radius, float thickness, Color color)
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, float radius, float thickness, float angle)
		{
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, float radius, float thickness, float angle, Color color)
		{
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, float radius, float thickness, float angle, float roundness, Color color)
		{
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, int sideCount)
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, int sideCount, Color color)
		{
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, int sideCount, float radius)
		{
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, int sideCount, float radius, Color color)
		{
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness)
		{
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, Color color)
		{
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, float angle)
		{
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, float angle, Color color)
		{
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, float angle, float roundness, Color color)
		{
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow()
		{
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(Color color)
		{
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(float radius)
		{
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(float radius, Color color)
		{
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(float radius, float thickness)
		{
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(float radius, float thickness, Color color)
		{
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(float radius, float thickness, float angle)
		{
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(float radius, float thickness, float angle, Color color)
		{
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(float radius, float thickness, float angle, float roundness, Color color)
		{
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(int sideCount)
		{
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(int sideCount, Color color)
		{
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(int sideCount, float radius)
		{
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(int sideCount, float radius, Color color)
		{
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(int sideCount, float radius, float thickness)
		{
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(int sideCount, float radius, float thickness, Color color)
		{
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(int sideCount, float radius, float thickness, float angle)
		{
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(int sideCount, float radius, float thickness, float angle, Color color)
		{
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(int sideCount, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollow(int sideCount, float radius, float thickness, float angle, float roundness, Color color)
		{
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos)
		{
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, GradientFill fill)
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, float radius)
		{
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, float radius, GradientFill fill)
		{
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, float radius, float angle)
		{
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, float radius, float angle, GradientFill fill)
		{
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, float radius, float angle, float roundness)
		{
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, float radius, float angle, float roundness, GradientFill fill)
		{
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, int sideCount)
		{
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, int sideCount, GradientFill fill)
		{
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, int sideCount, float radius)
		{
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, int sideCount, float radius, GradientFill fill)
		{
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, int sideCount, float radius, float angle)
		{
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, int sideCount, float radius, float angle, GradientFill fill)
		{
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, int sideCount, float radius, float angle, float roundness)
		{
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, int sideCount, float radius, float angle, float roundness, GradientFill fill)
		{
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Vector3 normal)
		{
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Vector3 normal, GradientFill fill)
		{
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Vector3 normal, float radius)
		{
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Vector3 normal, float radius, GradientFill fill)
		{
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Vector3 normal, float radius, float angle)
		{
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Vector3 normal, float radius, float angle, GradientFill fill)
		{
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Vector3 normal, float radius, float angle, float roundness)
		{
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Vector3 normal, float radius, float angle, float roundness, GradientFill fill)
		{
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Vector3 normal, int sideCount)
		{
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Vector3 normal, int sideCount, GradientFill fill)
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Vector3 normal, int sideCount, float radius)
		{
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Vector3 normal, int sideCount, float radius, GradientFill fill)
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Vector3 normal, int sideCount, float radius, float angle)
		{
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Vector3 normal, int sideCount, float radius, float angle, GradientFill fill)
		{
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Vector3 normal, int sideCount, float radius, float angle, float roundness)
		{
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Vector3 normal, int sideCount, float radius, float angle, float roundness, GradientFill fill)
		{
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Quaternion rot, GradientFill fill)
		{
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Quaternion rot, float radius)
		{
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Quaternion rot, float radius, GradientFill fill)
		{
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Quaternion rot, float radius, float angle)
		{
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Quaternion rot, float radius, float angle, GradientFill fill)
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Quaternion rot, float radius, float angle, float roundness)
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Quaternion rot, float radius, float angle, float roundness, GradientFill fill)
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Quaternion rot, int sideCount)
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Quaternion rot, int sideCount, GradientFill fill)
		{
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Quaternion rot, int sideCount, float radius)
		{
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Quaternion rot, int sideCount, float radius, GradientFill fill)
		{
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Quaternion rot, int sideCount, float radius, float angle)
		{
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Quaternion rot, int sideCount, float radius, float angle, GradientFill fill)
		{
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Quaternion rot, int sideCount, float radius, float angle, float roundness)
		{
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(Vector3 pos, Quaternion rot, int sideCount, float radius, float angle, float roundness, GradientFill fill)
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill()
		{
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(GradientFill fill)
		{
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(float radius)
		{
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(float radius, GradientFill fill)
		{
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(float radius, float angle)
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(float radius, float angle, GradientFill fill)
		{
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(float radius, float angle, float roundness)
		{
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(float radius, float angle, float roundness, GradientFill fill)
		{
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(int sideCount)
		{
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(int sideCount, GradientFill fill)
		{
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(int sideCount, float radius)
		{
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(int sideCount, float radius, GradientFill fill)
		{
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(int sideCount, float radius, float angle)
		{
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(int sideCount, float radius, float angle, GradientFill fill)
		{
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(int sideCount, float radius, float angle, float roundness)
		{
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFill(int sideCount, float radius, float angle, float roundness, GradientFill fill)
		{
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos)
		{
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, GradientFill fill)
		{
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, float radius)
		{
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, float radius, GradientFill fill)
		{
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, float radius, float thickness)
		{
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, float radius, float thickness, GradientFill fill)
		{
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, float radius, float thickness, float angle)
		{
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, float radius, float thickness, float angle, GradientFill fill)
		{
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, float radius, float thickness, float angle, float roundness, GradientFill fill)
		{
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, int sideCount)
		{
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, int sideCount, GradientFill fill)
		{
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, int sideCount, float radius)
		{
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, int sideCount, float radius, GradientFill fill)
		{
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, int sideCount, float radius, float thickness)
		{
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, int sideCount, float radius, float thickness, GradientFill fill)
		{
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, int sideCount, float radius, float thickness, float angle)
		{
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, int sideCount, float radius, float thickness, float angle, GradientFill fill)
		{
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, int sideCount, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, int sideCount, float radius, float thickness, float angle, float roundness, GradientFill fill)
		{
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal)
		{
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, GradientFill fill)
		{
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, float radius)
		{
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, float radius, GradientFill fill)
		{
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, float radius, float thickness)
		{
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, float radius, float thickness, GradientFill fill)
		{
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, float radius, float thickness, float angle)
		{
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, float radius, float thickness, float angle, GradientFill fill)
		{
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, float radius, float thickness, float angle, float roundness, GradientFill fill)
		{
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, int sideCount)
		{
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, int sideCount, GradientFill fill)
		{
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, int sideCount, float radius)
		{
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, int sideCount, float radius, GradientFill fill)
		{
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness)
		{
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, GradientFill fill)
		{
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, float angle)
		{
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, float angle, GradientFill fill)
		{
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, float angle, float roundness, GradientFill fill)
		{
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, GradientFill fill)
		{
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, float radius)
		{
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, float radius, GradientFill fill)
		{
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, float radius, float thickness)
		{
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, float radius, float thickness, GradientFill fill)
		{
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, float radius, float thickness, float angle)
		{
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, float radius, float thickness, float angle, GradientFill fill)
		{
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, float radius, float thickness, float angle, float roundness, GradientFill fill)
		{
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, int sideCount)
		{
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, int sideCount, GradientFill fill)
		{
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, int sideCount, float radius)
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, int sideCount, float radius, GradientFill fill)
		{
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness)
		{
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, GradientFill fill)
		{
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, float angle)
		{
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, float angle, GradientFill fill)
		{
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, float angle, float roundness, GradientFill fill)
		{
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill()
		{
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(GradientFill fill)
		{
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(float radius)
		{
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(float radius, GradientFill fill)
		{
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(float radius, float thickness)
		{
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(float radius, float thickness, GradientFill fill)
		{
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(float radius, float thickness, float angle)
		{
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(float radius, float thickness, float angle, GradientFill fill)
		{
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(float radius, float thickness, float angle, float roundness, GradientFill fill)
		{
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(int sideCount)
		{
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(int sideCount, GradientFill fill)
		{
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(int sideCount, float radius)
		{
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(int sideCount, float radius, GradientFill fill)
		{
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(int sideCount, float radius, float thickness)
		{
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(int sideCount, float radius, float thickness, GradientFill fill)
		{
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(int sideCount, float radius, float thickness, float angle)
		{
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(int sideCount, float radius, float thickness, float angle, GradientFill fill)
		{
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(int sideCount, float radius, float thickness, float angle, float roundness)
		{
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFill(int sideCount, float radius, float thickness, float angle, float roundness, GradientFill fill)
		{
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, float radius, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, float radius, float angle, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, float radius, float angle, float roundness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, int sideCount, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, int sideCount, float radius, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, int sideCount, float radius, float angle, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, int sideCount, float radius, float angle, float roundness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Vector3 normal, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Vector3 normal, float radius, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Vector3 normal, float radius, float angle, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Vector3 normal, float radius, float angle, float roundness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Vector3 normal, int sideCount, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Vector3 normal, int sideCount, float radius, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Vector3 normal, int sideCount, float radius, float angle, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Vector3 normal, int sideCount, float radius, float angle, float roundness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Quaternion rot, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Quaternion rot, float radius, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Quaternion rot, float radius, float angle, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Quaternion rot, float radius, float angle, float roundness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Quaternion rot, int sideCount, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Quaternion rot, int sideCount, float radius, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Quaternion rot, int sideCount, float radius, float angle, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 pos, Quaternion rot, int sideCount, float radius, float angle, float roundness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(float radius, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(float radius, float angle, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(float radius, float angle, float roundness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(int sideCount, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(int sideCount, float radius, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(int sideCount, float radius, float angle, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillLinear(int sideCount, float radius, float angle, float roundness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, float radius, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, float radius, float thickness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, float radius, float thickness, float angle, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, float radius, float thickness, float angle, float roundness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, int sideCount, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, int sideCount, float radius, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, int sideCount, float radius, float thickness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, int sideCount, float radius, float thickness, float angle, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, int sideCount, float radius, float thickness, float angle, float roundness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Vector3 normal, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Vector3 normal, float radius, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Vector3 normal, float radius, float thickness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Vector3 normal, float radius, float thickness, float angle, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Vector3 normal, float radius, float thickness, float angle, float roundness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Vector3 normal, int sideCount, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Vector3 normal, int sideCount, float radius, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, float angle, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, float angle, float roundness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Quaternion rot, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Quaternion rot, float radius, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Quaternion rot, float radius, float thickness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Quaternion rot, float radius, float thickness, float angle, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Quaternion rot, float radius, float thickness, float angle, float roundness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Quaternion rot, int sideCount, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Quaternion rot, int sideCount, float radius, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, float angle, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, float angle, float roundness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(float radius, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(float radius, float thickness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(float radius, float thickness, float angle, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(float radius, float thickness, float angle, float roundness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(int sideCount, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(int sideCount, float radius, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(int sideCount, float radius, float thickness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(int sideCount, float radius, float thickness, float angle, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillLinear(int sideCount, float radius, float thickness, float angle, float roundness, Vector3 fillStart, Vector3 fillEnd, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, float radius, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, float radius, float angle, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, float radius, float angle, float roundness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, int sideCount, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, int sideCount, float radius, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, int sideCount, float radius, float angle, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, int sideCount, float radius, float angle, float roundness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Vector3 normal, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Vector3 normal, float radius, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Vector3 normal, float radius, float angle, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Vector3 normal, float radius, float angle, float roundness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Vector3 normal, int sideCount, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Vector3 normal, int sideCount, float radius, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Vector3 normal, int sideCount, float radius, float angle, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Vector3 normal, int sideCount, float radius, float angle, float roundness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Quaternion rot, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Quaternion rot, float radius, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Quaternion rot, float radius, float angle, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Quaternion rot, float radius, float angle, float roundness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Quaternion rot, int sideCount, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Quaternion rot, int sideCount, float radius, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Quaternion rot, int sideCount, float radius, float angle, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 pos, Quaternion rot, int sideCount, float radius, float angle, float roundness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(float radius, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(float radius, float angle, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(float radius, float angle, float roundness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(int sideCount, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(int sideCount, float radius, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(int sideCount, float radius, float angle, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RegularPolygonFillRadial(int sideCount, float radius, float angle, float roundness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, float radius, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, float radius, float thickness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, float radius, float thickness, float angle, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, float radius, float thickness, float angle, float roundness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, int sideCount, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, int sideCount, float radius, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, int sideCount, float radius, float thickness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, int sideCount, float radius, float thickness, float angle, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, int sideCount, float radius, float thickness, float angle, float roundness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Vector3 normal, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Vector3 normal, float radius, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Vector3 normal, float radius, float thickness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Vector3 normal, float radius, float thickness, float angle, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Vector3 normal, float radius, float thickness, float angle, float roundness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Vector3 normal, int sideCount, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Vector3 normal, int sideCount, float radius, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, float angle, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Vector3 normal, int sideCount, float radius, float thickness, float angle, float roundness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Quaternion rot, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Quaternion rot, float radius, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Quaternion rot, float radius, float thickness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Quaternion rot, float radius, float thickness, float angle, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Quaternion rot, float radius, float thickness, float angle, float roundness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Quaternion rot, int sideCount, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Quaternion rot, int sideCount, float radius, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, float angle, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 pos, Quaternion rot, int sideCount, float radius, float thickness, float angle, float roundness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(float radius, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(float radius, float thickness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(float radius, float thickness, float angle, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(float radius, float thickness, float angle, float roundness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(int sideCount, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(int sideCount, float radius, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(int sideCount, float radius, float thickness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(int sideCount, float radius, float thickness, float angle, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead", true)]
		public static void RegularPolygonHollowFillRadial(int sideCount, float radius, float thickness, float angle, float roundness, Vector3 fillOrigin, float fillRadius, Color fillColorStart, Color fillColorEnd, FillSpace fillSpace = FillSpace.Local)
		{
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Radial(...) )", true)]
		public static void DiscGradientRadial(Vector3 pos, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Radial(...) )", true)]
		public static void DiscGradientRadial(Vector3 pos, float radius, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Radial(...) )", true)]
		public static void DiscGradientRadial(Vector3 pos, Vector3 normal, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Radial(...) )", true)]
		public static void DiscGradientRadial(Vector3 pos, Vector3 normal, float radius, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Radial(...) )", true)]
		public static void DiscGradientRadial(Vector3 pos, Quaternion rot, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Radial(...) )", true)]
		public static void DiscGradientRadial(Vector3 pos, Quaternion rot, float radius, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Radial(...) )", true)]
		public static void DiscGradientRadial(Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Radial(...) )", true)]
		public static void DiscGradientRadial(float radius, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Angular(...) )", true)]
		public static void DiscGradientAngular(Vector3 pos, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Angular(...) )", true)]
		public static void DiscGradientAngular(Vector3 pos, float radius, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Angular(...) )", true)]
		public static void DiscGradientAngular(Vector3 pos, Vector3 normal, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Angular(...) )", true)]
		public static void DiscGradientAngular(Vector3 pos, Vector3 normal, float radius, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Angular(...) )", true)]
		public static void DiscGradientAngular(Vector3 pos, Quaternion rot, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Angular(...) )", true)]
		public static void DiscGradientAngular(Vector3 pos, Quaternion rot, float radius, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Angular(...) )", true)]
		public static void DiscGradientAngular(Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Angular(...) )", true)]
		public static void DiscGradientAngular(float radius, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Bilinear(...) )", true)]
		public static void DiscGradientBilinear(Vector3 pos, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Bilinear(...) )", true)]
		public static void DiscGradientBilinear(Vector3 pos, float radius, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Bilinear(...) )", true)]
		public static void DiscGradientBilinear(Vector3 pos, Vector3 normal, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Bilinear(...) )", true)]
		public static void DiscGradientBilinear(Vector3 pos, Vector3 normal, float radius, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Bilinear(...) )", true)]
		public static void DiscGradientBilinear(Vector3 pos, Quaternion rot, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Bilinear(...) )", true)]
		public static void DiscGradientBilinear(Vector3 pos, Quaternion rot, float radius, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Bilinear(...) )", true)]
		public static void DiscGradientBilinear(Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Bilinear(...) )", true)]
		public static void DiscGradientBilinear(float radius, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos)
		{
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Color color)
		{
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, float radius)
		{
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, float radius, Color color)
		{
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, float radius, float thickness)
		{
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, float radius, float thickness, Color color)
		{
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, DashStyle dashStyle)
		{
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, DashStyle dashStyle, Color color)
		{
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, DashStyle dashStyle, float radius)
		{
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, DashStyle dashStyle, float radius, Color color)
		{
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, DashStyle dashStyle, float radius, float thickness)
		{
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, DashStyle dashStyle, float radius, float thickness, Color color)
		{
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Vector3 normal)
		{
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Vector3 normal, Color color)
		{
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Vector3 normal, float radius)
		{
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Vector3 normal, float radius, Color color)
		{
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Vector3 normal, float radius, float thickness)
		{
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Vector3 normal, float radius, float thickness, Color color)
		{
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle)
		{
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, Color color)
		{
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius)
		{
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, Color color)
		{
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float thickness)
		{
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float thickness, Color color)
		{
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Quaternion rot, Color color)
		{
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Quaternion rot, float radius)
		{
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Quaternion rot, float radius, Color color)
		{
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Quaternion rot, float radius, float thickness)
		{
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Quaternion rot, float radius, float thickness, Color color)
		{
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle)
		{
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, Color color)
		{
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius)
		{
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, Color color)
		{
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float thickness)
		{
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float thickness, Color color)
		{
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed()
		{
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(Color color)
		{
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(float radius)
		{
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(float radius, Color color)
		{
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(float radius, float thickness)
		{
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(float radius, float thickness, Color color)
		{
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(DashStyle dashStyle)
		{
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(DashStyle dashStyle, Color color)
		{
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(DashStyle dashStyle, float radius)
		{
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(DashStyle dashStyle, float radius, Color color)
		{
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(DashStyle dashStyle, float radius, float thickness)
		{
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingDashed(DashStyle dashStyle, float radius, float thickness, Color color)
		{
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) )", true)]
		public static void RingGradientRadial(Vector3 pos, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) )", true)]
		public static void RingGradientRadial(Vector3 pos, float radius, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) )", true)]
		public static void RingGradientRadial(Vector3 pos, float radius, float thickness, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) )", true)]
		public static void RingGradientRadial(Vector3 pos, Vector3 normal, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) )", true)]
		public static void RingGradientRadial(Vector3 pos, Vector3 normal, float radius, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) )", true)]
		public static void RingGradientRadial(Vector3 pos, Vector3 normal, float radius, float thickness, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) )", true)]
		public static void RingGradientRadial(Vector3 pos, Quaternion rot, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) )", true)]
		public static void RingGradientRadial(Vector3 pos, Quaternion rot, float radius, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) )", true)]
		public static void RingGradientRadial(Vector3 pos, Quaternion rot, float radius, float thickness, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) )", true)]
		public static void RingGradientRadial(Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) )", true)]
		public static void RingGradientRadial(float radius, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) )", true)]
		public static void RingGradientRadial(float radius, float thickness, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, float radius, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, float radius, float thickness, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, DashStyle dashStyle, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, DashStyle dashStyle, float radius, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, DashStyle dashStyle, float radius, float thickness, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, Vector3 normal, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, Vector3 normal, float radius, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, Vector3 normal, float radius, float thickness, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float thickness, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, Quaternion rot, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, Quaternion rot, float radius, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, Quaternion rot, float radius, float thickness, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float thickness, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(float radius, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(float radius, float thickness, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(DashStyle dashStyle, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(DashStyle dashStyle, float radius, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientRadialDashed(DashStyle dashStyle, float radius, float thickness, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) )", true)]
		public static void RingGradientAngular(Vector3 pos, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) )", true)]
		public static void RingGradientAngular(Vector3 pos, float radius, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) )", true)]
		public static void RingGradientAngular(Vector3 pos, float radius, float thickness, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) )", true)]
		public static void RingGradientAngular(Vector3 pos, Vector3 normal, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) )", true)]
		public static void RingGradientAngular(Vector3 pos, Vector3 normal, float radius, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) )", true)]
		public static void RingGradientAngular(Vector3 pos, Vector3 normal, float radius, float thickness, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) )", true)]
		public static void RingGradientAngular(Vector3 pos, Quaternion rot, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) )", true)]
		public static void RingGradientAngular(Vector3 pos, Quaternion rot, float radius, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) )", true)]
		public static void RingGradientAngular(Vector3 pos, Quaternion rot, float radius, float thickness, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) )", true)]
		public static void RingGradientAngular(Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) )", true)]
		public static void RingGradientAngular(float radius, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) )", true)]
		public static void RingGradientAngular(float radius, float thickness, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, float radius, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, float radius, float thickness, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, DashStyle dashStyle, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, DashStyle dashStyle, float radius, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, DashStyle dashStyle, float radius, float thickness, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, Vector3 normal, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, Vector3 normal, float radius, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, Vector3 normal, float radius, float thickness, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float thickness, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, Quaternion rot, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, Quaternion rot, float radius, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, Quaternion rot, float radius, float thickness, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float thickness, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(float radius, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(float radius, float thickness, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(DashStyle dashStyle, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(DashStyle dashStyle, float radius, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientAngularDashed(DashStyle dashStyle, float radius, float thickness, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) )", true)]
		public static void RingGradientBilinear(Vector3 pos, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) )", true)]
		public static void RingGradientBilinear(Vector3 pos, float radius, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) )", true)]
		public static void RingGradientBilinear(Vector3 pos, float radius, float thickness, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) )", true)]
		public static void RingGradientBilinear(Vector3 pos, Vector3 normal, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) )", true)]
		public static void RingGradientBilinear(Vector3 pos, Vector3 normal, float radius, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) )", true)]
		public static void RingGradientBilinear(Vector3 pos, Vector3 normal, float radius, float thickness, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) )", true)]
		public static void RingGradientBilinear(Vector3 pos, Quaternion rot, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) )", true)]
		public static void RingGradientBilinear(Vector3 pos, Quaternion rot, float radius, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) )", true)]
		public static void RingGradientBilinear(Vector3 pos, Quaternion rot, float radius, float thickness, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) )", true)]
		public static void RingGradientBilinear(Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) )", true)]
		public static void RingGradientBilinear(float radius, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) )", true)]
		public static void RingGradientBilinear(float radius, float thickness, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, float radius, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, float radius, float thickness, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, DashStyle dashStyle, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, DashStyle dashStyle, float radius, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, DashStyle dashStyle, float radius, float thickness, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, Vector3 normal, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, Vector3 normal, float radius, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, Vector3 normal, float radius, float thickness, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float thickness, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, Quaternion rot, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, Quaternion rot, float radius, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, Quaternion rot, float radius, float thickness, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float thickness, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(float radius, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(float radius, float thickness, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(DashStyle dashStyle, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(DashStyle dashStyle, float radius, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void RingGradientBilinearDashed(DashStyle dashStyle, float radius, float thickness, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Radial(...) )", true)]
		public static void PieGradientRadial(Vector3 pos, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Radial(...) )", true)]
		public static void PieGradientRadial(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Radial(...) )", true)]
		public static void PieGradientRadial(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Radial(...) )", true)]
		public static void PieGradientRadial(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Radial(...) )", true)]
		public static void PieGradientRadial(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Radial(...) )", true)]
		public static void PieGradientRadial(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Radial(...) )", true)]
		public static void PieGradientRadial(float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Radial(...) )", true)]
		public static void PieGradientRadial(float radius, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Angular(...) )", true)]
		public static void PieGradientAngular(Vector3 pos, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Angular(...) )", true)]
		public static void PieGradientAngular(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Angular(...) )", true)]
		public static void PieGradientAngular(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Angular(...) )", true)]
		public static void PieGradientAngular(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Angular(...) )", true)]
		public static void PieGradientAngular(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Angular(...) )", true)]
		public static void PieGradientAngular(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Angular(...) )", true)]
		public static void PieGradientAngular(float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Angular(...) )", true)]
		public static void PieGradientAngular(float radius, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Bilinear(...) )", true)]
		public static void PieGradientBilinear(Vector3 pos, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Bilinear(...) )", true)]
		public static void PieGradientBilinear(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Bilinear(...) )", true)]
		public static void PieGradientBilinear(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Bilinear(...) )", true)]
		public static void PieGradientBilinear(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Bilinear(...) )", true)]
		public static void PieGradientBilinear(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Bilinear(...) )", true)]
		public static void PieGradientBilinear(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Bilinear(...) )", true)]
		public static void PieGradientBilinear(float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Bilinear(...) )", true)]
		public static void PieGradientBilinear(float radius, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, float radius, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, DashStyle dashStyle, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, DashStyle dashStyle, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(float radius, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(float radius, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(float radius, float thickness, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(float radius, float thickness, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(DashStyle dashStyle, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(DashStyle dashStyle, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd)
		{
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, Color color)
		{
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps)
		{
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcDashed(DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color color)
		{
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(float radius, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )", true)]
		public static void ArcGradientRadial(float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, DashStyle dashStyle, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(float radius, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(DashStyle dashStyle, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientRadialDashed(DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInner, Color colorOuter)
		{
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(float radius, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )", true)]
		public static void ArcGradientAngular(float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000845")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, DashStyle dashStyle, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000858")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(float radius, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(DashStyle dashStyle, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientAngularDashed(DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorStart, Color colorEnd)
		{
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(float radius, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )", true)]
		public static void ArcGradientBilinear(float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600088D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, DashStyle dashStyle, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600088F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000892")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000893")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000894")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Vector3 normal, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000895")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Vector3 normal, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000897")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000898")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Vector3 normal, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Vector3 normal, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Quaternion rot, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Quaternion rot, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Quaternion rot, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(Vector3 pos, Quaternion rot, DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(float radius, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(DashStyle dashStyle, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(DashStyle dashStyle, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(DashStyle dashStyle, float radius, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) ). In addition: As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle", true)]
		public static void ArcGradientBilinearDashed(DashStyle dashStyle, float radius, float thickness, float angleRadStart, float angleRadEnd, ArcEndCap endCaps, Color colorInnerStart, Color colorOuterStart, Color colorInnerEnd, Color colorOuterEnd)
		{
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Rect rect)
		{
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Rect rect, GradientFill fill)
		{
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Rect rect, float cornerRadius)
		{
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Rect rect, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Rect rect, Vector4 cornerRadii)
		{
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Rect rect, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Rect rect)
		{
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Rect rect, GradientFill fill)
		{
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Rect rect, float cornerRadius)
		{
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Rect rect, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Rect rect, Vector4 cornerRadii)
		{
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Rect rect, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Rect rect)
		{
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Rect rect, GradientFill fill)
		{
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Rect rect, float cornerRadius)
		{
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Rect rect, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Rect rect, Vector4 cornerRadii)
		{
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Rect rect, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector2 size)
		{
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector2 size, GradientFill fill)
		{
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector2 size, float cornerRadius)
		{
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector2 size, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector2 size, Vector4 cornerRadii)
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector2 size, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, float width, float height)
		{
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, float width, float height, GradientFill fill)
		{
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, float width, float height, float cornerRadius)
		{
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, float width, float height, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, float width, float height, Vector4 cornerRadii)
		{
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, float width, float height, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Vector2 size)
		{
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Vector2 size, GradientFill fill)
		{
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Vector2 size, float cornerRadius)
		{
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Vector2 size, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Vector2 size, Vector4 cornerRadii)
		{
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Vector2 size, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, float width, float height)
		{
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, float width, float height, GradientFill fill)
		{
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, float width, float height, float cornerRadius)
		{
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, float width, float height, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, float width, float height, Vector4 cornerRadii)
		{
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, float width, float height, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Vector2 size)
		{
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Vector2 size, GradientFill fill)
		{
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Vector2 size, float cornerRadius)
		{
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Vector2 size, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Vector2 size, Vector4 cornerRadii)
		{
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Vector2 size, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, float width, float height)
		{
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, float width, float height, GradientFill fill)
		{
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, float width, float height, float cornerRadius)
		{
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, float width, float height, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, float width, float height, Vector4 cornerRadii)
		{
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, float width, float height, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Rect rect)
		{
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Rect rect, GradientFill fill)
		{
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Rect rect, float cornerRadius)
		{
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Rect rect, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Rect rect, Vector4 cornerRadii)
		{
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Rect rect, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector2 size, RectPivot pivot)
		{
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector2 size, RectPivot pivot, GradientFill fill)
		{
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector2 size, RectPivot pivot, float cornerRadius)
		{
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector2 size, RectPivot pivot, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector2 size, RectPivot pivot, Vector4 cornerRadii)
		{
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector2 size, RectPivot pivot, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, float width, float height, RectPivot pivot)
		{
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, float width, float height, RectPivot pivot, GradientFill fill)
		{
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, float width, float height, RectPivot pivot, float cornerRadius)
		{
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, float width, float height, RectPivot pivot, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, float width, float height, RectPivot pivot, Vector4 cornerRadii)
		{
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, float width, float height, RectPivot pivot, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot)
		{
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, GradientFill fill)
		{
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, float cornerRadius)
		{
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot)
		{
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, GradientFill fill)
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, float cornerRadius)
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000909")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, Vector4 cornerRadii)
		{
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600090B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot)
		{
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, GradientFill fill)
		{
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, float cornerRadius)
		{
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot)
		{
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, GradientFill fill)
		{
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, float cornerRadius)
		{
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000915")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleFill(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Rect rect, float thickness)
		{
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Rect rect, float thickness, GradientFill fill)
		{
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Rect rect, float thickness, float cornerRadius)
		{
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600091A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Rect rect, float thickness, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600091B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Rect rect, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600091C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Rect rect, float thickness, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600091D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Rect rect, float thickness)
		{
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600091E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Rect rect, float thickness, GradientFill fill)
		{
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600091F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Rect rect, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000920")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Rect rect, float thickness, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Rect rect, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Rect rect, float thickness, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Rect rect, float thickness)
		{
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Rect rect, float thickness, GradientFill fill)
		{
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Rect rect, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Rect rect, float thickness, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000927")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Rect rect, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000928")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Rect rect, float thickness, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000929")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector2 size, float thickness)
		{
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector2 size, float thickness, GradientFill fill)
		{
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector2 size, float thickness, float cornerRadius)
		{
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector2 size, float thickness, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector2 size, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector2 size, float thickness, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, float width, float height, float thickness)
		{
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000930")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, float width, float height, float thickness, GradientFill fill)
		{
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, float width, float height, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, float width, float height, float thickness, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000933")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, float width, float height, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, float width, float height, float thickness, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000935")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Vector2 size, float thickness)
		{
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000936")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Vector2 size, float thickness, GradientFill fill)
		{
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000937")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Vector2 size, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Vector2 size, float thickness, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Vector2 size, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Vector2 size, float thickness, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600093B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, float width, float height, float thickness)
		{
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, float width, float height, float thickness, GradientFill fill)
		{
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, float width, float height, float thickness, float cornerRadius)
		{
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, float width, float height, float thickness, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, float width, float height, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, float width, float height, float thickness, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Vector2 size, float thickness)
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Vector2 size, float thickness, GradientFill fill)
		{
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Vector2 size, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Vector2 size, float thickness, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Vector2 size, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Vector2 size, float thickness, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, float width, float height, float thickness)
		{
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, float width, float height, float thickness, GradientFill fill)
		{
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, float width, float height, float thickness, float cornerRadius)
		{
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, float width, float height, float thickness, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, float width, float height, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, float width, float height, float thickness, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Rect rect, float thickness)
		{
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Rect rect, float thickness, GradientFill fill)
		{
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Rect rect, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Rect rect, float thickness, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Rect rect, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Rect rect, float thickness, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector2 size, RectPivot pivot, float thickness)
		{
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector2 size, RectPivot pivot, float thickness, GradientFill fill)
		{
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector2 size, RectPivot pivot, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector2 size, RectPivot pivot, float thickness, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector2 size, RectPivot pivot, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector2 size, RectPivot pivot, float thickness, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, float width, float height, RectPivot pivot, float thickness)
		{
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, float width, float height, RectPivot pivot, float thickness, GradientFill fill)
		{
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, float width, float height, RectPivot pivot, float thickness, float cornerRadius)
		{
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, float width, float height, RectPivot pivot, float thickness, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, float width, float height, RectPivot pivot, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, float width, float height, RectPivot pivot, float thickness, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, float thickness)
		{
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000960")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, float thickness, GradientFill fill)
		{
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000961")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000962")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, float thickness, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000963")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000964")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, Vector2 size, RectPivot pivot, float thickness, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, float thickness)
		{
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000966")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, float thickness, GradientFill fill)
		{
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000967")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, float thickness, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000969")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600096A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Vector3 normal, float width, float height, RectPivot pivot, float thickness, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600096B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, float thickness)
		{
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600096C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, float thickness, GradientFill fill)
		{
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600096D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, float thickness, float cornerRadius)
		{
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600096E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, float thickness, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600096F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000970")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, Vector2 size, RectPivot pivot, float thickness, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000971")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, float thickness)
		{
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000972")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, float thickness, GradientFill fill)
		{
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000973")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, float thickness, float cornerRadius)
		{
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, float thickness, float cornerRadius, GradientFill fill)
		{
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, float thickness, Vector4 cornerRadii)
		{
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000976")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill", true)]
		public static void RectangleBorderFill(Vector3 pos, Quaternion rot, float width, float height, RectPivot pivot, float thickness, Vector4 cornerRadii, GradientFill fill)
		{
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.TriangleBorder instead", true)]
		public static void TriangleHollow(Vector3 a, Vector3 b, Vector3 c)
		{
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.TriangleBorder instead", true)]
		public static void TriangleHollow(Vector3 a, Vector3 b, Vector3 c, Color color)
		{
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.TriangleBorder instead", true)]
		public static void TriangleHollow(Vector3 a, Vector3 b, Vector3 c, Color colorA, Color colorB, Color colorC)
		{
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.TriangleBorder instead", true)]
		public static void TriangleHollow(Vector3 a, Vector3 b, Vector3 c, float thickness)
		{
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.TriangleBorder instead", true)]
		public static void TriangleHollow(Vector3 a, Vector3 b, Vector3 c, float thickness, Color color)
		{
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.TriangleBorder instead", true)]
		public static void TriangleHollow(Vector3 a, Vector3 b, Vector3 c, float thickness, Color colorA, Color colorB, Color colorC)
		{
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.TriangleBorder instead", true)]
		public static void TriangleHollow(Vector3 a, Vector3 b, Vector3 c, float thickness, float roundness)
		{
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.TriangleBorder instead", true)]
		public static void TriangleHollow(Vector3 a, Vector3 b, Vector3 c, float thickness, float roundness, Color color)
		{
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.TriangleBorder instead", true)]
		public static void TriangleHollow(Vector3 a, Vector3 b, Vector3 c, float thickness, float roundness, Color colorA, Color colorB, Color colorC)
		{
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x2A14960", Offset = "0x2A12F60", VA = "0x182A14960")]
		public static void ResetAllDrawStates()
		{
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00003B3C File Offset: 0x00001D3C
		[Token(Token = "0x170000FA")]
		public static StateStack Scope
		{
			[Token(Token = "0x6000982")]
			[Address(RVA = "0x2A14C20", Offset = "0x2A13220", VA = "0x182A14C20")]
			get
			{
				return default(StateStack);
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x2A14D40", Offset = "0x2A13340", VA = "0x182A14D40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Push()
		{
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x2A14E60", Offset = "0x2A13460", VA = "0x182A14E60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Pop()
		{
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x00003B54 File Offset: 0x00001D54
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000FB")]
		public static Matrix4x4 Matrix
		{
			[Token(Token = "0x6000985")]
			[Address(RVA = "0x2A14E70", Offset = "0x2A13470", VA = "0x182A14E70")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Matrix4x4);
			}
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x2A14EF0", Offset = "0x2A134F0", VA = "0x182A14EF0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000987")]
		[Address(RVA = "0x2A14F70", Offset = "0x2A13570", VA = "0x182A14F70")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ResetMatrix()
		{
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00003B6C File Offset: 0x00001D6C
		[Token(Token = "0x170000FC")]
		public static MatrixStack MatrixScope
		{
			[Token(Token = "0x6000988")]
			[Address(RVA = "0x2A15040", Offset = "0x2A13640", VA = "0x182A15040")]
			get
			{
				return default(MatrixStack);
			}
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000989")]
		[Address(RVA = "0x2A15190", Offset = "0x2A13790", VA = "0x182A15190")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushMatrix()
		{
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600098A")]
		[Address(RVA = "0x2A152F0", Offset = "0x2A138F0", VA = "0x182A152F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopMatrix()
		{
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600098B")]
		[Address(RVA = "0x2A15330", Offset = "0x2A13930", VA = "0x182A15330")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ApplyMatrix(Matrix4x4 matrix)
		{
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x00003B84 File Offset: 0x00001D84
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000FD")]
		public static Vector3 Position
		{
			[Token(Token = "0x600098C")]
			[Address(RVA = "0x2A154D0", Offset = "0x2A13AD0", VA = "0x182A154D0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600098D")]
			[Address(RVA = "0x2A15540", Offset = "0x2A13B40", VA = "0x182A15540")]
			set
			{
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00003B9C File Offset: 0x00001D9C
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000FE")]
		public static Vector2 Position2D
		{
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x2A155D0", Offset = "0x2A13BD0", VA = "0x182A155D0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600098F")]
			[Address(RVA = "0x2A15640", Offset = "0x2A13C40", VA = "0x182A15640")]
			set
			{
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x00003BB4 File Offset: 0x00001DB4
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000FF")]
		[Obsolete("Please use Draw.Position instead (I done messed up, did a typo, I'm sorry~)", true)]
		public static Vector3 Postition
		{
			[Token(Token = "0x6000990")]
			[Address(RVA = "0x2A156C0", Offset = "0x2A13CC0", VA = "0x182A156C0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000991")]
			[Address(RVA = "0x2A15770", Offset = "0x2A13D70", VA = "0x182A15770")]
			set
			{
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00003BCC File Offset: 0x00001DCC
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000100")]
		[Obsolete("Please use Draw.Position2D instead (I done messed up, did a typo, I'm sorry~)", true)]
		public static Vector2 Postition2D
		{
			[Token(Token = "0x6000992")]
			[Address(RVA = "0x2A15850", Offset = "0x2A13E50", VA = "0x182A15850")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000993")]
			[Address(RVA = "0x2A158F0", Offset = "0x2A13EF0", VA = "0x182A158F0")]
			set
			{
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00003BE4 File Offset: 0x00001DE4
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000101")]
		public static Quaternion Rotation
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0x2A159A0", Offset = "0x2A13FA0", VA = "0x182A159A0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000995")]
			[Address(RVA = "0x2A15A60", Offset = "0x2A14060", VA = "0x182A15A60")]
			set
			{
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00003BFC File Offset: 0x00001DFC
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000102")]
		public static float Angle2D
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x2A15C70", Offset = "0x2A14270", VA = "0x182A15C70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000997")]
			[Address(RVA = "0x2A15D00", Offset = "0x2A14300", VA = "0x182A15D00")]
			set
			{
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x00003C14 File Offset: 0x00001E14
		[Token(Token = "0x17000103")]
		public static Vector3 Right
		{
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x2A15DE0", Offset = "0x2A143E0", VA = "0x182A15DE0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x00003C2C File Offset: 0x00001E2C
		[Token(Token = "0x17000104")]
		public static Vector3 Up
		{
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x2A15F20", Offset = "0x2A14520", VA = "0x182A15F20")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x00003C44 File Offset: 0x00001E44
		[Token(Token = "0x17000105")]
		public static Vector3 Forward
		{
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x2A16070", Offset = "0x2A14670", VA = "0x182A16070")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x00003C5C File Offset: 0x00001E5C
		[Token(Token = "0x17000106")]
		public static Vector3 RightBasis
		{
			[Token(Token = "0x600099B")]
			[Address(RVA = "0x2A161C0", Offset = "0x2A147C0", VA = "0x182A161C0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x00003C74 File Offset: 0x00001E74
		[Token(Token = "0x17000107")]
		public static Vector3 UpBasis
		{
			[Token(Token = "0x600099C")]
			[Address(RVA = "0x2A16240", Offset = "0x2A14840", VA = "0x182A16240")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00003C8C File Offset: 0x00001E8C
		[Token(Token = "0x17000108")]
		public static Vector3 ForwardBasis
		{
			[Token(Token = "0x600099D")]
			[Address(RVA = "0x2A162C0", Offset = "0x2A148C0", VA = "0x182A162C0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00003CA4 File Offset: 0x00001EA4
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000109")]
		public static Vector3 LocalScale
		{
			[Token(Token = "0x600099E")]
			[Address(RVA = "0x2A16340", Offset = "0x2A14940", VA = "0x182A16340")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600099F")]
			[Address(RVA = "0x2A16520", Offset = "0x2A14B20", VA = "0x182A16520")]
			set
			{
			}
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x2A16730", Offset = "0x2A14D30", VA = "0x182A16730")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Translate(float x, float y)
		{
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x2A16860", Offset = "0x2A14E60", VA = "0x182A16860")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Translate(float x, float y, float z)
		{
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x2A16900", Offset = "0x2A14F00", VA = "0x182A16900")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Translate(Vector2 displacement)
		{
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x2A16A50", Offset = "0x2A15050", VA = "0x182A16A50")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Translate(Vector3 displacement)
		{
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x2A16AB0", Offset = "0x2A150B0", VA = "0x182A16AB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rotate(float angle)
		{
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x2A16B10", Offset = "0x2A15110", VA = "0x182A16B10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rotate(float x, float y, float z)
		{
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x2A16C20", Offset = "0x2A15220", VA = "0x182A16C20")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rotate(float angle, Vector3 axis)
		{
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x2A16CF0", Offset = "0x2A152F0", VA = "0x182A16CF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Rotate(Quaternion rotation)
		{
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x2A16E20", Offset = "0x2A15420", VA = "0x182A16E20")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Scale(float uniformScale)
		{
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x2A16E90", Offset = "0x2A15490", VA = "0x182A16E90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Scale(float x, float y)
		{
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x2A16FA0", Offset = "0x2A155A0", VA = "0x182A16FA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Scale(float x, float y, float z)
		{
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x2A17040", Offset = "0x2A15640", VA = "0x182A17040")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Scale(Vector2 scale)
		{
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x2A17170", Offset = "0x2A15770", VA = "0x182A17170")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Scale(Vector3 scale)
		{
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x2A171D0", Offset = "0x2A157D0", VA = "0x182A171D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMatrix(Matrix4x4 matrix)
		{
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x2A17280", Offset = "0x2A15880", VA = "0x182A17280")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMatrix(Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x2A173F0", Offset = "0x2A159F0", VA = "0x182A173F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMatrix(Transform transform)
		{
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x2A17510", Offset = "0x2A15B10", VA = "0x182A17510")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void MtxSetRotationKeepScale(ref Matrix4x4 m, Quaternion rotation)
		{
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x2A176B0", Offset = "0x2A15CB0", VA = "0x182A176B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void MtxRotateZLhs(ref Matrix4x4 rhs, float a)
		{
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x2A17880", Offset = "0x2A15E80", VA = "0x182A17880")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void MtxTranslateXYZ(ref Matrix4x4 lhs, double x, double y, double z)
		{
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x2A17970", Offset = "0x2A15F70", VA = "0x182A17970")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void MtxTranslateXY(ref Matrix4x4 lhs, double x, double y)
		{
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x2A17A10", Offset = "0x2A16010", VA = "0x182A17A10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void MtxRotateZ(ref Matrix4x4 lhs, float a)
		{
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x2A17B90", Offset = "0x2A16190", VA = "0x182A17B90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void MtxScaleXYZ(ref Matrix4x4 m, double x, double y, double z)
		{
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x2A17C50", Offset = "0x2A16250", VA = "0x182A17C50")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void MtxScaleXY(ref Matrix4x4 m, double x, double y)
		{
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x2A17CD0", Offset = "0x2A162D0", VA = "0x182A17CD0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void MtxResetToXYZ(out Matrix4x4 m, float x, float y, float z)
		{
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x2A17D70", Offset = "0x2A16370", VA = "0x182A17D70")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void MtxResetToXY(out Matrix4x4 m, float x, float y)
		{
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x2A17DF0", Offset = "0x2A163F0", VA = "0x182A17DF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void MtxResetToPosXYatAngle(out Matrix4x4 lhs, float x, float y, float a)
		{
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x2A17EB0", Offset = "0x2A164B0", VA = "0x182A17EB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void MtxResetToPosXYatDirection(out Matrix4x4 lhs, float x, float y, Vector2 dir)
		{
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x2A17FC0", Offset = "0x2A165C0", VA = "0x182A17FC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void MtxResetScaleSetAngleZ(ref Matrix4x4 lhs, float a)
		{
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x2A18030", Offset = "0x2A16630", VA = "0x182A18030")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void MtxResetScaleSetDirX(ref Matrix4x4 lhs, Vector2 dir)
		{
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x2A180D0", Offset = "0x2A166D0", VA = "0x182A180D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ResetStyle()
		{
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x00003CBC File Offset: 0x00001EBC
		[Token(Token = "0x1700010A")]
		public static StyleStack StyleScope
		{
			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x2A182B0", Offset = "0x2A168B0", VA = "0x182A182B0")]
			get
			{
				return default(StyleStack);
			}
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x2A18470", Offset = "0x2A16A70", VA = "0x182A18470")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyle()
		{
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x2A18600", Offset = "0x2A16C00", VA = "0x182A18600")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopStyle()
		{
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00003CD4 File Offset: 0x00001ED4
		[Token(Token = "0x1700010B")]
		public static ColorStack ColorScope
		{
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x2A18640", Offset = "0x2A16C40", VA = "0x182A18640")]
			get
			{
				return default(ColorStack);
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x2A18760", Offset = "0x2A16D60", VA = "0x182A18760")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushColor()
		{
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x2A188A0", Offset = "0x2A16EA0", VA = "0x182A188A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopColor()
		{
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00003CEC File Offset: 0x00001EEC
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x2A188E0", Offset = "0x2A16EE0", VA = "0x182A188E0")]
		public static DashStack DashedScope()
		{
			return default(DashStack);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00003D04 File Offset: 0x00001F04
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x2A18B20", Offset = "0x2A17120", VA = "0x182A18B20")]
		public static DashStack DashedScope(DashStyle dashStyle)
		{
			return default(DashStack);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00003D1C File Offset: 0x00001F1C
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x2A18DD0", Offset = "0x2A173D0", VA = "0x182A18DD0")]
		public static GradientFillStack GradientFillScope()
		{
			return default(GradientFillStack);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00003D34 File Offset: 0x00001F34
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x2A19050", Offset = "0x2A17650", VA = "0x182A19050")]
		public static GradientFillStack GradientFillScope(GradientFill fill)
		{
			return default(GradientFillStack);
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x00003D4C File Offset: 0x00001F4C
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700010C")]
		public static CompareFunction ZTest
		{
			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x2A19350", Offset = "0x2A17950", VA = "0x182A19350")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return CompareFunction.Disabled;
			}
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x2A193B0", Offset = "0x2A179B0", VA = "0x182A193B0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x00003D64 File Offset: 0x00001F64
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700010D")]
		public static float ZOffsetFactor
		{
			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x2A19410", Offset = "0x2A17A10", VA = "0x182A19410")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x2A19470", Offset = "0x2A17A70", VA = "0x182A19470")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x00003D7C File Offset: 0x00001F7C
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700010E")]
		public static int ZOffsetUnits
		{
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x2A194D0", Offset = "0x2A17AD0", VA = "0x182A194D0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x2A19530", Offset = "0x2A17B30", VA = "0x182A19530")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x00003D94 File Offset: 0x00001F94
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700010F")]
		public static CompareFunction StencilComp
		{
			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x2A19590", Offset = "0x2A17B90", VA = "0x182A19590")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return CompareFunction.Disabled;
			}
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x2A195F0", Offset = "0x2A17BF0", VA = "0x182A195F0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x00003DAC File Offset: 0x00001FAC
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000110")]
		public static StencilOp StencilOpPass
		{
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x2A19650", Offset = "0x2A17C50", VA = "0x182A19650")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return StencilOp.Keep;
			}
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x2A196B0", Offset = "0x2A17CB0", VA = "0x182A196B0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x00003DC4 File Offset: 0x00001FC4
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000111")]
		public static byte StencilRefID
		{
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x2A19710", Offset = "0x2A17D10", VA = "0x182A19710")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x2A19770", Offset = "0x2A17D70", VA = "0x182A19770")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x00003DDC File Offset: 0x00001FDC
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000112")]
		public static byte StencilReadMask
		{
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x2A197D0", Offset = "0x2A17DD0", VA = "0x182A197D0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x2A19830", Offset = "0x2A17E30", VA = "0x182A19830")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x00003DF4 File Offset: 0x00001FF4
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000113")]
		public static byte StencilWriteMask
		{
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x2A19890", Offset = "0x2A17E90", VA = "0x182A19890")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x2A198F0", Offset = "0x2A17EF0", VA = "0x182A198F0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x00003E0C File Offset: 0x0000200C
		// (set) Token: 0x060009D9 RID: 2521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000114")]
		public static Color Color
		{
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x2A19950", Offset = "0x2A17F50", VA = "0x182A19950")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x2A199B0", Offset = "0x2A17FB0", VA = "0x182A199B0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x00003E24 File Offset: 0x00002024
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000115")]
		public static float Opacity
		{
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x2A19A10", Offset = "0x2A18010", VA = "0x182A19A10")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x2A19AA0", Offset = "0x2A180A0", VA = "0x182A19AA0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x00003E3C File Offset: 0x0000203C
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000116")]
		public static ShapesBlendMode BlendMode
		{
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x2A19BA0", Offset = "0x2A181A0", VA = "0x182A19BA0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return ShapesBlendMode.Opaque;
			}
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x2A19C00", Offset = "0x2A18200", VA = "0x182A19C00")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x00003E54 File Offset: 0x00002054
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000117")]
		public static ScaleMode ScaleMode
		{
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x2A19C60", Offset = "0x2A18260", VA = "0x182A19C60")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return ScaleMode.Uniform;
			}
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x2A19CC0", Offset = "0x2A182C0", VA = "0x182A19CC0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00003E6C File Offset: 0x0000206C
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000118")]
		public static DetailLevel DetailLevel
		{
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x2A19D20", Offset = "0x2A18320", VA = "0x182A19D20")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return DetailLevel.Minimal;
			}
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x2A19D80", Offset = "0x2A18380", VA = "0x182A19D80")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x00003E84 File Offset: 0x00002084
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000119")]
		public static float Thickness
		{
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x2A19DE0", Offset = "0x2A183E0", VA = "0x182A19DE0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x2A19E40", Offset = "0x2A18440", VA = "0x182A19E40")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00003E9C File Offset: 0x0000209C
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700011A")]
		public static float Radius
		{
			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x2A19EA0", Offset = "0x2A184A0", VA = "0x182A19EA0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x2A19F00", Offset = "0x2A18500", VA = "0x182A19F00")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00003EB4 File Offset: 0x000020B4
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700011B")]
		public static ThicknessSpace ThicknessSpace
		{
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x2A19F60", Offset = "0x2A18560", VA = "0x182A19F60")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x2A19FC0", Offset = "0x2A185C0", VA = "0x182A19FC0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x00003ECC File Offset: 0x000020CC
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700011C")]
		public static ThicknessSpace RadiusSpace
		{
			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x2A1A020", Offset = "0x2A18620", VA = "0x182A1A020")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x2A1A080", Offset = "0x2A18680", VA = "0x182A1A080")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x00003EE4 File Offset: 0x000020E4
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700011D")]
		public static ThicknessSpace SizeSpace
		{
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x2A1A0E0", Offset = "0x2A186E0", VA = "0x182A1A0E0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x2A1A140", Offset = "0x2A18740", VA = "0x182A1A140")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x00003EFC File Offset: 0x000020FC
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700011E")]
		public static bool UseGradientFill
		{
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x2A1A1A0", Offset = "0x2A187A0", VA = "0x182A1A1A0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x2A1A200", Offset = "0x2A18800", VA = "0x182A1A200")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x00003F14 File Offset: 0x00002114
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700011F")]
		public static GradientFill GradientFill
		{
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x2A1A260", Offset = "0x2A18860", VA = "0x182A1A260")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(GradientFill);
			}
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x2A1A2F0", Offset = "0x2A188F0", VA = "0x182A1A2F0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00003F2C File Offset: 0x0000212C
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000120")]
		public static FillType GradientFillType
		{
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x2A1A380", Offset = "0x2A18980", VA = "0x182A1A380")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return FillType.LinearGradient;
			}
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x2A1A3E0", Offset = "0x2A189E0", VA = "0x182A1A3E0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00003F44 File Offset: 0x00002144
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000121")]
		public static FillSpace GradientFillSpace
		{
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x2A1A440", Offset = "0x2A18A40", VA = "0x182A1A440")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return FillSpace.Local;
			}
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x2A1A4A0", Offset = "0x2A18AA0", VA = "0x182A1A4A0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00003F5C File Offset: 0x0000215C
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000122")]
		public static Color GradientFillColorStart
		{
			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x2A1A500", Offset = "0x2A18B00", VA = "0x182A1A500")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x2A1A560", Offset = "0x2A18B60", VA = "0x182A1A560")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00003F74 File Offset: 0x00002174
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000123")]
		public static Color GradientFillColorEnd
		{
			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x2A1A5C0", Offset = "0x2A18BC0", VA = "0x182A1A5C0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x2A1A620", Offset = "0x2A18C20", VA = "0x182A1A620")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x00003F8C File Offset: 0x0000218C
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000124")]
		public static Vector3 GradientFillLinearStart
		{
			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x2A1A680", Offset = "0x2A18C80", VA = "0x182A1A680")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x2A1A6F0", Offset = "0x2A18CF0", VA = "0x182A1A6F0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x00003FA4 File Offset: 0x000021A4
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000125")]
		public static Vector3 GradientFillLinearEnd
		{
			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x2A1A760", Offset = "0x2A18D60", VA = "0x182A1A760")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x2A1A7D0", Offset = "0x2A18DD0", VA = "0x182A1A7D0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x00003FBC File Offset: 0x000021BC
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000126")]
		public static Vector3 GradientFillRadialOrigin
		{
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x2A1A840", Offset = "0x2A18E40", VA = "0x182A1A840")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x2A1A8B0", Offset = "0x2A18EB0", VA = "0x182A1A8B0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x00003FD4 File Offset: 0x000021D4
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000127")]
		public static float GradientFillRadialRadius
		{
			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x2A1A920", Offset = "0x2A18F20", VA = "0x182A1A920")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x2A1A980", Offset = "0x2A18F80", VA = "0x182A1A980")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00003FEC File Offset: 0x000021EC
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000128")]
		public static bool UseDashes
		{
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x2A1A9E0", Offset = "0x2A18FE0", VA = "0x182A1A9E0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x2A1AA40", Offset = "0x2A19040", VA = "0x182A1AA40")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00004004 File Offset: 0x00002204
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000129")]
		public static DashStyle DashStyle
		{
			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x2A1AAA0", Offset = "0x2A190A0", VA = "0x182A1AAA0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(DashStyle);
			}
			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x2A1AB20", Offset = "0x2A19120", VA = "0x182A1AB20")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0000401C File Offset: 0x0000221C
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700012A")]
		public static DashType DashType
		{
			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x2A1AB90", Offset = "0x2A19190", VA = "0x182A1AB90")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return DashType.Basic;
			}
			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x2A1ABF0", Offset = "0x2A191F0", VA = "0x182A1ABF0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00004034 File Offset: 0x00002234
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700012B")]
		public static DashSpace DashSpace
		{
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x2A1AC50", Offset = "0x2A19250", VA = "0x182A1AC50")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return DashSpace.Meters;
			}
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x2A1ACB0", Offset = "0x2A192B0", VA = "0x182A1ACB0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0000404C File Offset: 0x0000224C
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700012C")]
		public static DashSnapping DashSnap
		{
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x2A1AD10", Offset = "0x2A19310", VA = "0x182A1AD10")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return DashSnapping.Off;
			}
			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x2A1AD70", Offset = "0x2A19370", VA = "0x182A1AD70")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00004064 File Offset: 0x00002264
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700012D")]
		public static float DashSize
		{
			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x2A1ADD0", Offset = "0x2A193D0", VA = "0x182A1ADD0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x2A1AE30", Offset = "0x2A19430", VA = "0x182A1AE30")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0000407C File Offset: 0x0000227C
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700012E")]
		public static float DashSizeUniform
		{
			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x2A1AE90", Offset = "0x2A19490", VA = "0x182A1AE90")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x2A1AEF0", Offset = "0x2A194F0", VA = "0x182A1AEF0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00004094 File Offset: 0x00002294
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700012F")]
		public static float DashSpacing
		{
			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x2A1AF90", Offset = "0x2A19590", VA = "0x182A1AF90")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x2A1AFF0", Offset = "0x2A195F0", VA = "0x182A1AFF0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x000040AC File Offset: 0x000022AC
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000130")]
		public static float DashOffset
		{
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x2A1B050", Offset = "0x2A19650", VA = "0x182A1B050")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x2A1B0B0", Offset = "0x2A196B0", VA = "0x182A1B0B0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x000040C4 File Offset: 0x000022C4
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000131")]
		public static float DashShapeModifier
		{
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x2A1B110", Offset = "0x2A19710", VA = "0x182A1B110")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x2A1B170", Offset = "0x2A19770", VA = "0x182A1B170")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x000040DC File Offset: 0x000022DC
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000132")]
		public static LineEndCap LineEndCaps
		{
			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x2A1B1D0", Offset = "0x2A197D0", VA = "0x182A1B1D0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return LineEndCap.None;
			}
			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x2A1B230", Offset = "0x2A19830", VA = "0x182A1B230")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x000040F4 File Offset: 0x000022F4
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000133")]
		public static LineGeometry LineGeometry
		{
			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x2A1B290", Offset = "0x2A19890", VA = "0x182A1B290")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return LineGeometry.Flat2D;
			}
			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x2A1B2F0", Offset = "0x2A198F0", VA = "0x182A1B2F0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0000410C File Offset: 0x0000230C
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000134")]
		public static PolygonTriangulation PolygonTriangulation
		{
			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x2A1B350", Offset = "0x2A19950", VA = "0x182A1B350")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return PolygonTriangulation.FastConvexOnly;
			}
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x2A1B3B0", Offset = "0x2A199B0", VA = "0x182A1B3B0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00004124 File Offset: 0x00002324
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000135")]
		public static PolylineGeometry PolylineGeometry
		{
			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x2A1B410", Offset = "0x2A19A10", VA = "0x182A1B410")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return PolylineGeometry.Flat2D;
			}
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x2A1B470", Offset = "0x2A19A70", VA = "0x182A1B470")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0000413C File Offset: 0x0000233C
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000136")]
		public static PolylineJoins PolylineJoins
		{
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x2A1B4D0", Offset = "0x2A19AD0", VA = "0x182A1B4D0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return PolylineJoins.Simple;
			}
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x2A1B530", Offset = "0x2A19B30", VA = "0x182A1B530")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00004154 File Offset: 0x00002354
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000137")]
		public static DiscGeometry DiscGeometry
		{
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x2A1B590", Offset = "0x2A19B90", VA = "0x182A1B590")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return DiscGeometry.Flat2D;
			}
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x2A1B5F0", Offset = "0x2A19BF0", VA = "0x182A1B5F0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0000416C File Offset: 0x0000236C
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000138")]
		public static int RegularPolygonSideCount
		{
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x2A1B650", Offset = "0x2A19C50", VA = "0x182A1B650")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x2A1B6B0", Offset = "0x2A19CB0", VA = "0x182A1B6B0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00004184 File Offset: 0x00002384
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000139")]
		public static RegularPolygonGeometry RegularPolygonGeometry
		{
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x2A1B710", Offset = "0x2A19D10", VA = "0x182A1B710")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return RegularPolygonGeometry.Flat2D;
			}
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x2A1B770", Offset = "0x2A19D70", VA = "0x182A1B770")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0000419C File Offset: 0x0000239C
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700013A")]
		public static TextStyle TextStyle
		{
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x2A1B7D0", Offset = "0x2A19DD0", VA = "0x182A1B7D0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(TextStyle);
			}
			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x2A1B860", Offset = "0x2A19E60", VA = "0x182A1B860")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0000210E File Offset: 0x0000030E
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700013B")]
		public static TMP_FontAsset Font
		{
			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x2A1B940", Offset = "0x2A19F40", VA = "0x182A1B940")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x2A1B9A0", Offset = "0x2A19FA0", VA = "0x182A1B9A0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x000041B4 File Offset: 0x000023B4
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700013C")]
		public static float FontSize
		{
			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x2A1BA40", Offset = "0x2A1A040", VA = "0x182A1BA40")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x2A1BAA0", Offset = "0x2A1A0A0", VA = "0x182A1BAA0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x000041CC File Offset: 0x000023CC
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700013D")]
		public static FontStyles FontStyle
		{
			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x2A1BB00", Offset = "0x2A1A100", VA = "0x182A1BB00")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return FontStyles.Normal;
			}
			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x2A1BB60", Offset = "0x2A1A160", VA = "0x182A1BB60")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x000041E4 File Offset: 0x000023E4
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700013E")]
		public static TextAlign TextAlign
		{
			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x2A1BBC0", Offset = "0x2A1A1C0", VA = "0x182A1BBC0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return TextAlign.TopLeft;
			}
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x2A1BC20", Offset = "0x2A1A220", VA = "0x182A1BC20")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x000041FC File Offset: 0x000023FC
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700013F")]
		public static float TextCharacterSpacing
		{
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x2A1BC80", Offset = "0x2A1A280", VA = "0x182A1BC80")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x2A1BCE0", Offset = "0x2A1A2E0", VA = "0x182A1BCE0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00004214 File Offset: 0x00002414
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000140")]
		public static float TextWordSpacing
		{
			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x2A1BD40", Offset = "0x2A1A340", VA = "0x182A1BD40")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x2A1BDA0", Offset = "0x2A1A3A0", VA = "0x182A1BDA0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0000422C File Offset: 0x0000242C
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000141")]
		public static float TextLineSpacing
		{
			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x2A1BE00", Offset = "0x2A1A400", VA = "0x182A1BE00")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x2A1BE60", Offset = "0x2A1A460", VA = "0x182A1BE60")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00004244 File Offset: 0x00002444
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000142")]
		public static float TextParagraphSpacing
		{
			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x2A1BEC0", Offset = "0x2A1A4C0", VA = "0x182A1BEC0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x2A1BF20", Offset = "0x2A1A520", VA = "0x182A1BF20")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0000425C File Offset: 0x0000245C
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000143")]
		public static Vector4 TextMargins
		{
			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x2A1BF80", Offset = "0x2A1A580", VA = "0x182A1BF80")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x2A1BFE0", Offset = "0x2A1A5E0", VA = "0x182A1BFE0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x00004274 File Offset: 0x00002474
		// (set) Token: 0x06000A39 RID: 2617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000144")]
		[Obsolete("All shapes now use the same static Thickness property", true)]
		public static float LineThickness
		{
			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x2A1C040", Offset = "0x2A1A640", VA = "0x182A1C040")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x2A1C0A0", Offset = "0x2A1A6A0", VA = "0x182A1C0A0")]
			set
			{
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x0000428C File Offset: 0x0000248C
		// (set) Token: 0x06000A3B RID: 2619 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000145")]
		[Obsolete("All shapes now use the same static ThicknessSpace property", true)]
		public static ThicknessSpace LineThicknessSpace
		{
			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x2A1C100", Offset = "0x2A1A700", VA = "0x182A1C100")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x2A1C160", Offset = "0x2A1A760", VA = "0x182A1C160")]
			set
			{
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x000042A4 File Offset: 0x000024A4
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000146")]
		[Obsolete("All shapes now use the same static DashStyle property by default, when UseDashes is enabled", true)]
		public static DashStyle LineDashStyle
		{
			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x2A1C1C0", Offset = "0x2A1A7C0", VA = "0x182A1C1C0")]
			get
			{
				return default(DashStyle);
			}
			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x2A1C240", Offset = "0x2A1A840", VA = "0x182A1C240")]
			set
			{
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x000042BC File Offset: 0x000024BC
		// (set) Token: 0x06000A3F RID: 2623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000147")]
		[Obsolete("All shapes now use the same static Radius property", true)]
		public static float DiscRadius
		{
			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x2A1C2B0", Offset = "0x2A1A8B0", VA = "0x182A1C2B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x2A1C310", Offset = "0x2A1A910", VA = "0x182A1C310")]
			set
			{
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x000042D4 File Offset: 0x000024D4
		// (set) Token: 0x06000A41 RID: 2625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000148")]
		[Obsolete("All shapes now use the same static DashStyle property by default, when UseDashes is enabled", true)]
		public static DashStyle RingDashStyle
		{
			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x2A1C370", Offset = "0x2A1A970", VA = "0x182A1C370")]
			get
			{
				return default(DashStyle);
			}
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x2A1C3F0", Offset = "0x2A1A9F0", VA = "0x182A1C3F0")]
			set
			{
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x000042EC File Offset: 0x000024EC
		// (set) Token: 0x06000A43 RID: 2627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000149")]
		[Obsolete("All shapes now use the same static GradientFill property by default. If you want to override shape fill per shape, use the draw overload with a fill input", true)]
		public static GradientFill PolygonShapeFill
		{
			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x2A1C460", Offset = "0x2A1AA60", VA = "0x182A1C460")]
			get
			{
				return default(GradientFill);
			}
			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x2A1C4F0", Offset = "0x2A1AAF0", VA = "0x182A1C4F0")]
			set
			{
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x00004304 File Offset: 0x00002504
		// (set) Token: 0x06000A45 RID: 2629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700014A")]
		[Obsolete("All shapes now use the same static GradientFill property by default. If you want to override shape fill per shape, use the draw overload with a fill input", true)]
		public static GradientFill RegularPolygonShapeFill
		{
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x2A1C580", Offset = "0x2A1AB80", VA = "0x182A1C580")]
			get
			{
				return default(GradientFill);
			}
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x2A1C610", Offset = "0x2A1AC10", VA = "0x182A1C610")]
			set
			{
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0000431C File Offset: 0x0000251C
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700014B")]
		[Obsolete("All shapes now use the same static GradientFill property by default. If you want to override shape fill per shape, use the draw overload with a fill input", true)]
		public static GradientFill RectangleShapeFill
		{
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x2A1C6A0", Offset = "0x2A1ACA0", VA = "0x182A1C6A0")]
			get
			{
				return default(GradientFill);
			}
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x2A1C730", Offset = "0x2A1AD30", VA = "0x182A1C730")]
			set
			{
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00004334 File Offset: 0x00002534
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700014C")]
		[Obsolete("All shapes now use the same static Thickness property", true)]
		public static float RingThickness
		{
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x2A1C7C0", Offset = "0x2A1ADC0", VA = "0x182A1C7C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x2A1C820", Offset = "0x2A1AE20", VA = "0x182A1C820")]
			set
			{
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x0000434C File Offset: 0x0000254C
		// (set) Token: 0x06000A4B RID: 2635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700014D")]
		[Obsolete("All shapes now use the same static ThicknessSpace property", true)]
		public static ThicknessSpace RingThicknessSpace
		{
			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x2A1C880", Offset = "0x2A1AE80", VA = "0x182A1C880")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x2A1C8E0", Offset = "0x2A1AEE0", VA = "0x182A1C8E0")]
			set
			{
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x00004364 File Offset: 0x00002564
		// (set) Token: 0x06000A4D RID: 2637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700014E")]
		[Obsolete("All shapes now use the same static RadiusSpace property", true)]
		public static ThicknessSpace DiscRadiusSpace
		{
			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x2A1C940", Offset = "0x2A1AF40", VA = "0x182A1C940")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x2A1C9A0", Offset = "0x2A1AFA0", VA = "0x182A1C9A0")]
			set
			{
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x0000437C File Offset: 0x0000257C
		// (set) Token: 0x06000A4F RID: 2639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700014F")]
		[Obsolete("All shapes now use the same static Radius property", true)]
		public static float RegularPolygonRadius
		{
			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x2A1CA00", Offset = "0x2A1B000", VA = "0x182A1CA00")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x2A1CA60", Offset = "0x2A1B060", VA = "0x182A1CA60")]
			set
			{
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x00004394 File Offset: 0x00002594
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000150")]
		[Obsolete("All shapes now use the same static Thickness property", true)]
		public static float RegularPolygonThickness
		{
			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x2A1CAC0", Offset = "0x2A1B0C0", VA = "0x182A1CAC0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x2A1CB20", Offset = "0x2A1B120", VA = "0x182A1CB20")]
			set
			{
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x000043AC File Offset: 0x000025AC
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000151")]
		[Obsolete("All shapes now use the same static ThicknessSpace property", true)]
		public static ThicknessSpace RegularPolygonThicknessSpace
		{
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x2A1CB80", Offset = "0x2A1B180", VA = "0x182A1CB80")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x2A1CBE0", Offset = "0x2A1B1E0", VA = "0x182A1CBE0")]
			set
			{
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x000043C4 File Offset: 0x000025C4
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000152")]
		[Obsolete("All shapes now use the same static RadiusSpace property", true)]
		public static ThicknessSpace RegularPolygonRadiusSpace
		{
			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x2A1CC40", Offset = "0x2A1B240", VA = "0x182A1CC40")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x2A1CCA0", Offset = "0x2A1B2A0", VA = "0x182A1CCA0")]
			set
			{
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x000043DC File Offset: 0x000025DC
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000153")]
		[Obsolete("All shapes now use the same static Thickness property", true)]
		public static float RectangleThickness
		{
			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x2A1CD00", Offset = "0x2A1B300", VA = "0x182A1CD00")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x2A1CD60", Offset = "0x2A1B360", VA = "0x182A1CD60")]
			set
			{
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x000043F4 File Offset: 0x000025F4
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000154")]
		[Obsolete("All shapes now use the same static ThicknessSpace property", true)]
		public static ThicknessSpace RectangleThicknessSpace
		{
			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x2A1CDC0", Offset = "0x2A1B3C0", VA = "0x182A1CDC0")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x2A1CE20", Offset = "0x2A1B420", VA = "0x182A1CE20")]
			set
			{
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0000440C File Offset: 0x0000260C
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000155")]
		[Obsolete("All shapes now use the same static Thickness property", true)]
		public static float TriangleThickness
		{
			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x2A1CE80", Offset = "0x2A1B480", VA = "0x182A1CE80")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x2A1CEE0", Offset = "0x2A1B4E0", VA = "0x182A1CEE0")]
			set
			{
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00004424 File Offset: 0x00002624
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000156")]
		[Obsolete("All shapes now use the same static ThicknessSpace property", true)]
		public static ThicknessSpace TriangleThicknessSpace
		{
			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x2A1CF40", Offset = "0x2A1B540", VA = "0x182A1CF40")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x2A1CFA0", Offset = "0x2A1B5A0", VA = "0x182A1CFA0")]
			set
			{
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0000443C File Offset: 0x0000263C
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000157")]
		[Obsolete("All shapes now use the same static Radius property", true)]
		public static float SphereRadius
		{
			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x2A1D000", Offset = "0x2A1B600", VA = "0x182A1D000")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x2A1D060", Offset = "0x2A1B660", VA = "0x182A1D060")]
			set
			{
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00004454 File Offset: 0x00002654
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000158")]
		[Obsolete("All shapes now use the same static RadiusSpace property", true)]
		public static ThicknessSpace SphereRadiusSpace
		{
			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x2A1D0C0", Offset = "0x2A1B6C0", VA = "0x182A1D0C0")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x2A1D120", Offset = "0x2A1B720", VA = "0x182A1D120")]
			set
			{
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0000446C File Offset: 0x0000266C
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000159")]
		[Obsolete("All shapes now use the same static SizeSpace property", true)]
		public static ThicknessSpace CuboidSizeSpace
		{
			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x2A1D180", Offset = "0x2A1B780", VA = "0x182A1D180")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x2A1D1E0", Offset = "0x2A1B7E0", VA = "0x182A1D1E0")]
			set
			{
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00004484 File Offset: 0x00002684
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700015A")]
		[Obsolete("All shapes now use the same static ThicknessSpace property", true)]
		public static ThicknessSpace TorusThicknessSpace
		{
			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x2A1D240", Offset = "0x2A1B840", VA = "0x182A1D240")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x2A1D2A0", Offset = "0x2A1B8A0", VA = "0x182A1D2A0")]
			set
			{
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0000449C File Offset: 0x0000269C
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700015B")]
		[Obsolete("All shapes now use the same static RadiusSpace property", true)]
		public static ThicknessSpace TorusRadiusSpace
		{
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x2A1D300", Offset = "0x2A1B900", VA = "0x182A1D300")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x2A1D360", Offset = "0x2A1B960", VA = "0x182A1D360")]
			set
			{
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x000044B4 File Offset: 0x000026B4
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700015C")]
		[Obsolete("All shapes now use the same static SizeSpace property", true)]
		public static ThicknessSpace ConeSizeSpace
		{
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x2A1D3C0", Offset = "0x2A1B9C0", VA = "0x182A1D3C0")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x2A1D420", Offset = "0x2A1BA20", VA = "0x182A1D420")]
			set
			{
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x2A1D480", Offset = "0x2A1BA80", VA = "0x182A1D480")]
		[CompilerGenerated]
		internal static void <Polyline_Internal>g__ApplyToMpb|6_0(MpbPolyline2D mpb, ref Draw.<>c__DisplayClass6_0 A_1)
		{
		}

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		private const MethodImplOptions INLINE = MethodImplOptions.AggressiveInlining;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x0")]
		private static MpbLine2D mpbLine;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x8")]
		private static MpbPolyline2D mpbPolyline;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x10")]
		private static MpbPolyline2D mpbPolylineJoins;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x18")]
		private static MpbPolygon mpbPolygon;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x20")]
		private static readonly MpbDisc mpbDisc;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x28")]
		private static readonly MpbRegularPolygon mpbRegularPolygon;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x30")]
		private static readonly MpbRect mpbRect;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x38")]
		private static MpbTriangle mpbTriangle;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x40")]
		private static MpbQuad mpbQuad;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x48")]
		private static readonly MpbSphere metaMpbSphere;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x50")]
		private static readonly MpbCone mpbCone;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x58")]
		private static readonly MpbCuboid mpbCuboid;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x60")]
		private static MpbTorus mpbTorus;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x68")]
		private static MpbText mpbText;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x70")]
		private static MpbTexture mpbTexture;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		private const string OBS_DASH = "As of Shapes 4.0.0, dash state is now set using the global Draw.UseDashes and Draw.DashStyle";

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		private const string OBS_FILL = "As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill";

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		private const string OBS_REGPOLRENAME = "For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead";

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		private const string OBS_TRIRENAME = "For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.TriangleBorder instead";

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		private const string JOINER = ". In addition: ";

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		private const string OBS_REGPOLRENAME_AND_FILL = "As of Shapes 4.0.0, color fill is now set using the global Draw.UseGradientFill and Draw.GradientFill. In addition: For consistency, this has been renamed as of Shapes 4.0.0. Please use Draw.RegularPolygonBorder instead";

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		private const string OBS_DISC_GRADIENT_PREFIX = "As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.";

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		private const string OBS_DISC_GRADIENT_DISC_RADIAL = "As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Radial(...) )";

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		private const string OBS_DISC_GRADIENT_DISC_ANGULAR = "As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Angular(...) )";

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		private const string OBS_DISC_GRADIENT_DISC_BILINEAR = "As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Disc( ..., DiscColors.Bilinear(...) )";

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		private const string OBS_DISC_GRADIENT_RING_RADIAL = "As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Radial(...) )";

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		private const string OBS_DISC_GRADIENT_RING_ANGULAR = "As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Angular(...) )";

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		private const string OBS_DISC_GRADIENT_RING_BILINEAR = "As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Ring( ..., DiscColors.Bilinear(...) )";

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		private const string OBS_DISC_GRADIENT_PIE_RADIAL = "As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Radial(...) )";

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		private const string OBS_DISC_GRADIENT_PIE_ANGULAR = "As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Angular(...) )";

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		private const string OBS_DISC_GRADIENT_PIE_BILINEAR = "As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Pie( ..., DiscColors.Bilinear(...) )";

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		private const string OBS_DISC_GRADIENT_ARC_RADIAL = "As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Radial(...) )";

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		private const string OBS_DISC_GRADIENT_ARC_ANGULAR = "As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Angular(...) )";

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		private const string OBS_DISC_GRADIENT_ARC_BILINEAR = "As of Shapes 4.0.0, disc gradients are now defined using a DiscColors as the last parameter. Instead, please use Draw.Arc( ..., DiscColors.Bilinear(...) )";

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x78")]
		private static Matrix4x4 matrix;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0xB8")]
		internal static DrawStyle style;
	}
}
