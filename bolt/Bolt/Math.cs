using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Bolt
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	[Documentation]
	internal static class Math
	{
		// Token: 0x06000719 RID: 1817 RVA: 0x00004B18 File Offset: 0x00002D18
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x901B20", Offset = "0x900120", VA = "0x180901B20")]
		internal static float InterpolateFloat(BoltDoubleList<NetworkStorage> frames, int offset, int frame, bool angle)
		{
			return 0f;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00004B30 File Offset: 0x00002D30
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x901CF0", Offset = "0x9002F0", VA = "0x180901CF0")]
		internal static Vector3 InterpolateVector(BoltDoubleList<NetworkStorage> frames, int offset, int frame, float snapLimit)
		{
			return default(Vector3);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x901D50", Offset = "0x900350", VA = "0x180901D50")]
		internal static Vector3 InterpolateVector(BoltDoubleList<NetworkStorage> frames, int offset, int frame, float snapLimit, ref bool snapped)
		{
			return default(Vector3);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00004B60 File Offset: 0x00002D60
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x902000", Offset = "0x900600", VA = "0x180902000")]
		internal static Quaternion InterpolateQuaternion(BoltDoubleList<NetworkStorage> frames, int offset, int frame)
		{
			return default(Quaternion);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00004B78 File Offset: 0x00002D78
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x902380", Offset = "0x900980", VA = "0x180902380")]
		internal static Vector3 ExtrapolateVector(Vector3 cpos, Vector3 rpos, Vector3 rvel, int recievedFrame, int entityFrame, PropertyExtrapolationSettings settings, ref bool snapped)
		{
			return default(Vector3);
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00004B90 File Offset: 0x00002D90
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x902620", Offset = "0x900C20", VA = "0x180902620")]
		internal static Quaternion ExtrapolateQuaternion(Quaternion cquat, Quaternion rquat, int recievedFrame, int entityFrame, PropertyExtrapolationSettings settings)
		{
			return default(Quaternion);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x902B50", Offset = "0x901150", VA = "0x180902B50")]
		internal static int SequenceDistance(uint from, uint to, int shift)
		{
			return 0;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x902B70", Offset = "0x901170", VA = "0x180902B70")]
		public static int HighBit(uint v)
		{
			return 0;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00004BD8 File Offset: 0x00002DD8
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x902B80", Offset = "0x901180", VA = "0x180902B80")]
		public static int BytesRequired(int bits)
		{
			return 0;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x902B90", Offset = "0x901190", VA = "0x180902B90")]
		public static int BitsRequired(int number)
		{
			return 0;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x902C30", Offset = "0x901230", VA = "0x180902C30")]
		public static int PopCount(ulong value)
		{
			return 0;
		}
	}
}
