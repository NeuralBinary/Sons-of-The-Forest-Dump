using System;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public static class GizmosExtended
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawLabel(Vector3 position, string text, Color textColor, bool bold = false, bool italic = false, TextAnchor alignment = TextAnchor.UpperLeft)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		public static void DrawLabel(Vector3 position, string text)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0xA64FF0", Offset = "0xA635F0", VA = "0x180A64FF0")]
		public static void DrawCircle(Vector3 position, Quaternion rotation, float radius, float range = 360f, int steps = 32, bool connect = false, bool drawPie = true)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005D")]
		[Address(RVA = "0xA65700", Offset = "0xA63D00", VA = "0x180A65700")]
		public static void DrawMinMaxCube(Vector3 min, Vector3 max)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0xA65830", Offset = "0xA63E30", VA = "0x180A65830")]
		public static void DrawMinMaxWireCube(Vector3 min, Vector3 max)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0xA65EA0", Offset = "0xA644A0", VA = "0x180A65EA0")]
		public static void DrawArrow(Vector3 targetPos, Vector3 actorPos, float thickness)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0xA65EE0", Offset = "0xA644E0", VA = "0x180A65EE0")]
		public static void DrawWireArrow(Vector3 targetPos, Vector3 actorPos, float thickness)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		[Address(RVA = "0xA65F20", Offset = "0xA64520", VA = "0x180A65F20")]
		public static void DrawArrow(Vector3 actorPos, Quaternion lookRotation, float length, float thickness)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0xA65F60", Offset = "0xA64560", VA = "0x180A65F60")]
		public static void DrawWireArrow(Vector3 actorPos, Quaternion lookRotation, float length, float thickness)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private static void DrawArrowInternal(Vector3 targetPos, Vector3 actorPos, float thickness, bool wireframe)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private static void DrawArrowInternal(Vector3 actorPos, Quaternion lookRotation, float length, float thickness, bool wireframe)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0")]
		private static Mesh GetArrowMesh()
		{
			return null;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0")]
		private static Mesh GetRingMesh()
		{
			return null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0")]
		private static Mesh GetDirectionMesh()
		{
			return null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000068")]
		[Address(RVA = "0xA65FA0", Offset = "0xA645A0", VA = "0x180A65FA0")]
		public static void DrawWireRing(Vector3 transformPosition, Quaternion rotation, Vector3 size, bool wire = false)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000069")]
		[Address(RVA = "0xA66010", Offset = "0xA64610", VA = "0x180A66010")]
		public static void DrawRing(Vector3 transformPosition, Quaternion rotation, Vector3 size, bool wire = false)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private static void DrawRingInternal(Vector3 position, Quaternion rotation, Vector3 size, bool wireframe)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0xA66050", Offset = "0xA64650", VA = "0x180A66050")]
		public static void DrawWireDirection(Vector3 pos, Quaternion rotation)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006C")]
		[Address(RVA = "0xA660E0", Offset = "0xA646E0", VA = "0x180A660E0")]
		public static void DrawDirection(Vector3 pos, Quaternion rotation, bool wire = false)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private static void DrawDirectionInternal(Vector3 position, Quaternion rotation, Vector3 size, bool wireframe)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006E")]
		[Address(RVA = "0xA66140", Offset = "0xA64740", VA = "0x180A66140")]
		public static void DrawSphereTrace(Vector3 start, Vector3 end, float radius)
		{
		}

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x0")]
		private static GUIStyle labelStyle;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x8")]
		private static string _cachedArrowMeshPath;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x10")]
		private static string _cachedRingMeshPath;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x18")]
		private static string _cachedDirectionMeshPath;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x20")]
		private static Mesh _cachedRingMesh;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x28")]
		private static Mesh _cachedArrowMesh;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x30")]
		private static Mesh _cachedDirectionMesh;
	}
}
