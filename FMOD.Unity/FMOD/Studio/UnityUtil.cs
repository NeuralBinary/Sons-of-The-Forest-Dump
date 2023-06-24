using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace FMOD.Studio
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	public static class UnityUtil
	{
		// Token: 0x060004C3 RID: 1219 RVA: 0x00004B2C File Offset: 0x00002D2C
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xB3E7F0", Offset = "0xB3CDF0", VA = "0x180B3E7F0")]
		public static float LinearToDecibels(float linearGain)
		{
			return 0f;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00004B44 File Offset: 0x00002D44
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xB3E830", Offset = "0xB3CE30", VA = "0x180B3E830")]
		public static float DecibelsToLinear(float decibelGain)
		{
			return 0f;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00004B5C File Offset: 0x00002D5C
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xA60D20", Offset = "0xA5F320", VA = "0x180A60D20")]
		public static VECTOR toFMODVector(this Vector3 vec)
		{
			return default(VECTOR);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00004B74 File Offset: 0x00002D74
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xA60D20", Offset = "0xA5F320", VA = "0x180A60D20")]
		public static Vector3 toUnityVector(this VECTOR vec)
		{
			return default(Vector3);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00004B8C File Offset: 0x00002D8C
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xB3E860", Offset = "0xB3CE60", VA = "0x180B3E860")]
		public static ATTRIBUTES_3D to3DAttributes(this Vector3 pos)
		{
			return default(ATTRIBUTES_3D);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00004BA4 File Offset: 0x00002DA4
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xB3E970", Offset = "0xB3CF70", VA = "0x180B3E970")]
		public static ATTRIBUTES_3D to3DAttributes(this Transform transform)
		{
			return default(ATTRIBUTES_3D);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00004BBC File Offset: 0x00002DBC
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xB3EAB0", Offset = "0xB3D0B0", VA = "0x180B3EAB0")]
		public static ATTRIBUTES_3D to3DAttributes(GameObject go, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00004BD4 File Offset: 0x00002DD4
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xB3EC80", Offset = "0xB3D280", VA = "0x180B3EC80")]
		public static bool isPlaying(this PLAYBACK_STATE state)
		{
			return default(bool);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void Log(string msg)
		{
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xB3EC90", Offset = "0xB3D290", VA = "0x180B3EC90")]
		public static void LogWarning(string msg)
		{
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xB3ECE0", Offset = "0xB3D2E0", VA = "0x180B3ECE0")]
		public static void LogError(string msg)
		{
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00004BEC File Offset: 0x00002DEC
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xB3ED30", Offset = "0xB3D330", VA = "0x180B3ED30")]
		public static bool ForceLoadLowLevelBinary()
		{
			return default(bool);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00004C04 File Offset: 0x00002E04
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xB3EE50", Offset = "0xB3D450", VA = "0x180B3EE50")]
		public static bool ERRCHECK(RESULT result)
		{
			return default(bool);
		}

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		public const float MINIMUM_DECIBEL_VALUE = -80f;
	}
}
