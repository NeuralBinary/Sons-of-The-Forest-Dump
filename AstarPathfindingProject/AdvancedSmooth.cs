using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_advanced_smooth.php")]
	[AddComponentMenu("Pathfinding/Modifiers/Advanced Smooth")]
	[Serializable]
	public class AdvancedSmooth : MonoModifier
	{
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x000057D4 File Offset: 0x000039D4
		[Token(Token = "0x1700012A")]
		public override int Order
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x6BC980", Offset = "0x6BAF80", VA = "0x1806BC980", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x6BC990", Offset = "0x6BAF90", VA = "0x1806BC990", Slot = "17")]
		public override void Apply(Path p)
		{
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x6BCEE0", Offset = "0x6BB4E0", VA = "0x1806BCEE0")]
		private void EvaluatePaths(List<AdvancedSmooth.Turn> turnList, List<Vector3> output)
		{
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x6BD090", Offset = "0x6BB690", VA = "0x1806BD090")]
		public AdvancedSmooth()
		{
		}

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x30")]
		public float turningRadius;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x38")]
		public AdvancedSmooth.MaxTurn turnConstruct1;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x40")]
		public AdvancedSmooth.ConstantTurn turnConstruct2;

		// Token: 0x020000CC RID: 204
		[Token(Token = "0x20000CC")]
		[Serializable]
		public class MaxTurn : AdvancedSmooth.TurnConstructor
		{
			// Token: 0x06000760 RID: 1888 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x6BD2B0", Offset = "0x6BB8B0", VA = "0x1806BD2B0", Slot = "5")]
			public override void OnTangentUpdate()
			{
			}

			// Token: 0x06000761 RID: 1889 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x6BD470", Offset = "0x6BBA70", VA = "0x1806BD470", Slot = "4")]
			public override void Prepare(int i, Vector3[] vectorPath)
			{
			}

			// Token: 0x06000762 RID: 1890 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x6BD660", Offset = "0x6BBC60", VA = "0x1806BD660", Slot = "8")]
			public override void TangentToTangent(List<AdvancedSmooth.Turn> turnList)
			{
			}

			// Token: 0x06000763 RID: 1891 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000763")]
			[Address(RVA = "0x6BE8E0", Offset = "0x6BCEE0", VA = "0x1806BE8E0", Slot = "6")]
			public override void PointToTangent(List<AdvancedSmooth.Turn> turnList)
			{
			}

			// Token: 0x06000764 RID: 1892 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x6BF020", Offset = "0x6BD620", VA = "0x1806BF020", Slot = "7")]
			public override void TangentToPoint(List<AdvancedSmooth.Turn> turnList)
			{
			}

			// Token: 0x06000765 RID: 1893 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000765")]
			[Address(RVA = "0x6BF5E0", Offset = "0x6BDBE0", VA = "0x1806BF5E0", Slot = "9")]
			public override void GetPath(AdvancedSmooth.Turn turn, List<Vector3> output)
			{
			}

			// Token: 0x06000766 RID: 1894 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x6BFA80", Offset = "0x6BE080", VA = "0x1806BFA80")]
			public MaxTurn()
			{
			}

			// Token: 0x040004D3 RID: 1235
			[Token(Token = "0x40004D3")]
			[FieldOffset(Offset = "0x18")]
			private Vector3 preRightCircleCenter;

			// Token: 0x040004D4 RID: 1236
			[Token(Token = "0x40004D4")]
			[FieldOffset(Offset = "0x24")]
			private Vector3 preLeftCircleCenter;

			// Token: 0x040004D5 RID: 1237
			[Token(Token = "0x40004D5")]
			[FieldOffset(Offset = "0x30")]
			private Vector3 rightCircleCenter;

			// Token: 0x040004D6 RID: 1238
			[Token(Token = "0x40004D6")]
			[FieldOffset(Offset = "0x3C")]
			private Vector3 leftCircleCenter;

			// Token: 0x040004D7 RID: 1239
			[Token(Token = "0x40004D7")]
			[FieldOffset(Offset = "0x48")]
			private double vaRight;

			// Token: 0x040004D8 RID: 1240
			[Token(Token = "0x40004D8")]
			[FieldOffset(Offset = "0x50")]
			private double vaLeft;

			// Token: 0x040004D9 RID: 1241
			[Token(Token = "0x40004D9")]
			[FieldOffset(Offset = "0x58")]
			private double preVaLeft;

			// Token: 0x040004DA RID: 1242
			[Token(Token = "0x40004DA")]
			[FieldOffset(Offset = "0x60")]
			private double preVaRight;

			// Token: 0x040004DB RID: 1243
			[Token(Token = "0x40004DB")]
			[FieldOffset(Offset = "0x68")]
			private double gammaLeft;

			// Token: 0x040004DC RID: 1244
			[Token(Token = "0x40004DC")]
			[FieldOffset(Offset = "0x70")]
			private double gammaRight;

			// Token: 0x040004DD RID: 1245
			[Token(Token = "0x40004DD")]
			[FieldOffset(Offset = "0x78")]
			private double betaRightRight;

			// Token: 0x040004DE RID: 1246
			[Token(Token = "0x40004DE")]
			[FieldOffset(Offset = "0x80")]
			private double betaRightLeft;

			// Token: 0x040004DF RID: 1247
			[Token(Token = "0x40004DF")]
			[FieldOffset(Offset = "0x88")]
			private double betaLeftRight;

			// Token: 0x040004E0 RID: 1248
			[Token(Token = "0x40004E0")]
			[FieldOffset(Offset = "0x90")]
			private double betaLeftLeft;

			// Token: 0x040004E1 RID: 1249
			[Token(Token = "0x40004E1")]
			[FieldOffset(Offset = "0x98")]
			private double deltaRightLeft;

			// Token: 0x040004E2 RID: 1250
			[Token(Token = "0x40004E2")]
			[FieldOffset(Offset = "0xA0")]
			private double deltaLeftRight;

			// Token: 0x040004E3 RID: 1251
			[Token(Token = "0x40004E3")]
			[FieldOffset(Offset = "0xA8")]
			private double alfaRightRight;

			// Token: 0x040004E4 RID: 1252
			[Token(Token = "0x40004E4")]
			[FieldOffset(Offset = "0xB0")]
			private double alfaLeftLeft;

			// Token: 0x040004E5 RID: 1253
			[Token(Token = "0x40004E5")]
			[FieldOffset(Offset = "0xB8")]
			private double alfaRightLeft;

			// Token: 0x040004E6 RID: 1254
			[Token(Token = "0x40004E6")]
			[FieldOffset(Offset = "0xC0")]
			private double alfaLeftRight;
		}

		// Token: 0x020000CD RID: 205
		[Token(Token = "0x20000CD")]
		[Serializable]
		public class ConstantTurn : AdvancedSmooth.TurnConstructor
		{
			// Token: 0x06000767 RID: 1895 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000767")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
			public override void Prepare(int i, Vector3[] vectorPath)
			{
			}

			// Token: 0x06000768 RID: 1896 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x6BFB40", Offset = "0x6BE140", VA = "0x1806BFB40", Slot = "8")]
			public override void TangentToTangent(List<AdvancedSmooth.Turn> turnList)
			{
			}

			// Token: 0x06000769 RID: 1897 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x6C01E0", Offset = "0x6BE7E0", VA = "0x1806C01E0", Slot = "9")]
			public override void GetPath(AdvancedSmooth.Turn turn, List<Vector3> output)
			{
			}

			// Token: 0x0600076A RID: 1898 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x6C0660", Offset = "0x6BEC60", VA = "0x1806C0660")]
			public ConstantTurn()
			{
			}

			// Token: 0x040004E7 RID: 1255
			[Token(Token = "0x40004E7")]
			[FieldOffset(Offset = "0x18")]
			private Vector3 circleCenter;

			// Token: 0x040004E8 RID: 1256
			[Token(Token = "0x40004E8")]
			[FieldOffset(Offset = "0x28")]
			private double gamma1;

			// Token: 0x040004E9 RID: 1257
			[Token(Token = "0x40004E9")]
			[FieldOffset(Offset = "0x30")]
			private double gamma2;

			// Token: 0x040004EA RID: 1258
			[Token(Token = "0x40004EA")]
			[FieldOffset(Offset = "0x38")]
			private bool clockwise;
		}

		// Token: 0x020000CE RID: 206
		[Token(Token = "0x20000CE")]
		public abstract class TurnConstructor
		{
			// Token: 0x0600076B RID: 1899
			[Token(Token = "0x600076B")]
			public abstract void Prepare(int i, Vector3[] vectorPath);

			// Token: 0x0600076C RID: 1900 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
			public virtual void OnTangentUpdate()
			{
			}

			// Token: 0x0600076D RID: 1901 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
			public virtual void PointToTangent(List<AdvancedSmooth.Turn> turnList)
			{
			}

			// Token: 0x0600076E RID: 1902 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
			public virtual void TangentToPoint(List<AdvancedSmooth.Turn> turnList)
			{
			}

			// Token: 0x0600076F RID: 1903 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
			public virtual void TangentToTangent(List<AdvancedSmooth.Turn> turnList)
			{
			}

			// Token: 0x06000770 RID: 1904
			[Token(Token = "0x6000770")]
			public abstract void GetPath(AdvancedSmooth.Turn turn, List<Vector3> output);

			// Token: 0x06000771 RID: 1905 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000771")]
			[Address(RVA = "0x6C06B0", Offset = "0x6BECB0", VA = "0x1806C06B0")]
			public static void Setup(int i, Vector3[] vectorPath)
			{
			}

			// Token: 0x06000772 RID: 1906 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000772")]
			[Address(RVA = "0x6C0B70", Offset = "0x6BF170", VA = "0x1806C0B70")]
			public static void PostPrepare()
			{
			}

			// Token: 0x06000773 RID: 1907 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x6C0BC0", Offset = "0x6BF1C0", VA = "0x1806C0BC0")]
			public void AddCircleSegment(double startAngle, double endAngle, bool clockwise, Vector3 center, List<Vector3> output, float radius)
			{
			}

			// Token: 0x06000774 RID: 1908 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x6C10D0", Offset = "0x6BF6D0", VA = "0x1806C10D0")]
			public void DebugCircleSegment(Vector3 center, double startAngle, double endAngle, double radius, Color color)
			{
			}

			// Token: 0x06000775 RID: 1909 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x6C15F0", Offset = "0x6BFBF0", VA = "0x1806C15F0")]
			public void DebugCircle(Vector3 center, double radius, Color color)
			{
			}

			// Token: 0x06000776 RID: 1910 RVA: 0x000057EC File Offset: 0x000039EC
			[Token(Token = "0x6000776")]
			[Address(RVA = "0x6C1930", Offset = "0x6BFF30", VA = "0x1806C1930")]
			public double GetLengthFromAngle(double angle, double radius)
			{
				return 0.0;
			}

			// Token: 0x06000777 RID: 1911 RVA: 0x00005804 File Offset: 0x00003A04
			[Token(Token = "0x6000777")]
			[Address(RVA = "0x6C1940", Offset = "0x6BFF40", VA = "0x1806C1940")]
			public double ClockwiseAngle(double from, double to)
			{
				return 0.0;
			}

			// Token: 0x06000778 RID: 1912 RVA: 0x0000581C File Offset: 0x00003A1C
			[Token(Token = "0x6000778")]
			[Address(RVA = "0x6C1980", Offset = "0x6BFF80", VA = "0x1806C1980")]
			public double CounterClockwiseAngle(double from, double to)
			{
				return 0.0;
			}

			// Token: 0x06000779 RID: 1913 RVA: 0x00005834 File Offset: 0x00003A34
			[Token(Token = "0x6000779")]
			[Address(RVA = "0x6C19C0", Offset = "0x6BFFC0", VA = "0x1806C19C0")]
			public Vector3 AngleToVector(double a)
			{
				return default(Vector3);
			}

			// Token: 0x0600077A RID: 1914 RVA: 0x0000584C File Offset: 0x00003A4C
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x6C1A40", Offset = "0x6C0040", VA = "0x1806C1A40")]
			public double ToDegrees(double rad)
			{
				return 0.0;
			}

			// Token: 0x0600077B RID: 1915 RVA: 0x00005864 File Offset: 0x00003A64
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x6C1A50", Offset = "0x6C0050", VA = "0x1806C1A50")]
			public double ClampAngle(double a)
			{
				return 0.0;
			}

			// Token: 0x0600077C RID: 1916 RVA: 0x0000587C File Offset: 0x00003A7C
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x6C1A90", Offset = "0x6C0090", VA = "0x1806C1A90")]
			public double Atan2(Vector3 v)
			{
				return 0.0;
			}

			// Token: 0x0600077D RID: 1917 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x600077D")]
			[Address(RVA = "0x6C1AF0", Offset = "0x6C00F0", VA = "0x1806C1AF0")]
			protected TurnConstructor()
			{
			}

			// Token: 0x040004EB RID: 1259
			[Token(Token = "0x40004EB")]
			[FieldOffset(Offset = "0x10")]
			public float constantBias;

			// Token: 0x040004EC RID: 1260
			[Token(Token = "0x40004EC")]
			[FieldOffset(Offset = "0x14")]
			public float factorBias;

			// Token: 0x040004ED RID: 1261
			[Token(Token = "0x40004ED")]
			[FieldOffset(Offset = "0x0")]
			public static float turningRadius;

			// Token: 0x040004EE RID: 1262
			[Token(Token = "0x40004EE")]
			public const double ThreeSixtyRadians = 6.283185307179586;

			// Token: 0x040004EF RID: 1263
			[Token(Token = "0x40004EF")]
			[FieldOffset(Offset = "0x4")]
			public static Vector3 prev;

			// Token: 0x040004F0 RID: 1264
			[Token(Token = "0x40004F0")]
			[FieldOffset(Offset = "0x10")]
			public static Vector3 current;

			// Token: 0x040004F1 RID: 1265
			[Token(Token = "0x40004F1")]
			[FieldOffset(Offset = "0x1C")]
			public static Vector3 next;

			// Token: 0x040004F2 RID: 1266
			[Token(Token = "0x40004F2")]
			[FieldOffset(Offset = "0x28")]
			public static Vector3 t1;

			// Token: 0x040004F3 RID: 1267
			[Token(Token = "0x40004F3")]
			[FieldOffset(Offset = "0x34")]
			public static Vector3 t2;

			// Token: 0x040004F4 RID: 1268
			[Token(Token = "0x40004F4")]
			[FieldOffset(Offset = "0x40")]
			public static Vector3 normal;

			// Token: 0x040004F5 RID: 1269
			[Token(Token = "0x40004F5")]
			[FieldOffset(Offset = "0x4C")]
			public static Vector3 prevNormal;

			// Token: 0x040004F6 RID: 1270
			[Token(Token = "0x40004F6")]
			[FieldOffset(Offset = "0x58")]
			public static bool changedPreviousTangent;
		}

		// Token: 0x020000CF RID: 207
		[Token(Token = "0x20000CF")]
		public struct Turn : IComparable<AdvancedSmooth.Turn>
		{
			// Token: 0x1700012B RID: 299
			// (get) Token: 0x0600077F RID: 1919 RVA: 0x00005894 File Offset: 0x00003A94
			[Token(Token = "0x1700012B")]
			public float score
			{
				[Token(Token = "0x600077F")]
				[Address(RVA = "0x6C1B50", Offset = "0x6C0150", VA = "0x1806C1B50")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06000780 RID: 1920 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x6C1B80", Offset = "0x6C0180", VA = "0x1806C1B80")]
			public Turn(float length, AdvancedSmooth.TurnConstructor constructor, int id = 0)
			{
			}

			// Token: 0x06000781 RID: 1921 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x6C1BE0", Offset = "0x6C01E0", VA = "0x1806C1BE0")]
			public void GetPath(List<Vector3> output)
			{
			}

			// Token: 0x06000782 RID: 1922 RVA: 0x000058AC File Offset: 0x00003AAC
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x6C1C20", Offset = "0x6C0220", VA = "0x1806C1C20", Slot = "4")]
			public int CompareTo(AdvancedSmooth.Turn t)
			{
				return 0;
			}

			// Token: 0x06000783 RID: 1923 RVA: 0x000058C4 File Offset: 0x00003AC4
			[Token(Token = "0x6000783")]
			[Address(RVA = "0x6C1CA0", Offset = "0x6C02A0", VA = "0x1806C1CA0")]
			public static bool operator <(AdvancedSmooth.Turn lhs, AdvancedSmooth.Turn rhs)
			{
				return default(bool);
			}

			// Token: 0x06000784 RID: 1924 RVA: 0x000058DC File Offset: 0x00003ADC
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x6C1CF0", Offset = "0x6C02F0", VA = "0x1806C1CF0")]
			public static bool operator >(AdvancedSmooth.Turn lhs, AdvancedSmooth.Turn rhs)
			{
				return default(bool);
			}

			// Token: 0x040004F7 RID: 1271
			[Token(Token = "0x40004F7")]
			[FieldOffset(Offset = "0x0")]
			public float length;

			// Token: 0x040004F8 RID: 1272
			[Token(Token = "0x40004F8")]
			[FieldOffset(Offset = "0x4")]
			public int id;

			// Token: 0x040004F9 RID: 1273
			[Token(Token = "0x40004F9")]
			[FieldOffset(Offset = "0x8")]
			public AdvancedSmooth.TurnConstructor constructor;
		}
	}
}
