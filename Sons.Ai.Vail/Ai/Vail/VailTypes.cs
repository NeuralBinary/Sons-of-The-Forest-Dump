using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	public static class VailTypes
	{
		// Token: 0x0600086B RID: 2155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x2B6AD60", Offset = "0x2B69360", VA = "0x182B6AD60")]
		private static void InitializeTypeToClass()
		{
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00005C58 File Offset: 0x00003E58
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x2B6B820", Offset = "0x2B69E20", VA = "0x182B6B820")]
		public static VailActorClassId GetActorClass(VailActorTypeId typeId)
		{
			return VailActorClassId.None;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00005C70 File Offset: 0x00003E70
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x2B6B890", Offset = "0x2B69E90", VA = "0x182B6B890")]
		public static VailActorTypeId FindActorType(string filter)
		{
			return VailActorTypeId.None;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00005C88 File Offset: 0x00003E88
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x2B6BAA0", Offset = "0x2B6A0A0", VA = "0x182B6BAA0")]
		public static VailActorClassId FindActorClass(string filter)
		{
			return VailActorClassId.None;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00005CA0 File Offset: 0x00003EA0
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x2B6BCA0", Offset = "0x2B6A2A0", VA = "0x182B6BCA0")]
		public static bool IsMuddy(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00005CB8 File Offset: 0x00003EB8
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x2B6BCB0", Offset = "0x2B6A2B0", VA = "0x182B6BCB0")]
		public static bool IsFemaleCannibal(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00005CD0 File Offset: 0x00003ED0
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x2B6BCD0", Offset = "0x2B6A2D0", VA = "0x182B6BCD0")]
		public static bool IsMaleCannibal(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00005CE8 File Offset: 0x00003EE8
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x2B6BCF0", Offset = "0x2B6A2F0", VA = "0x182B6BCF0")]
		public static bool IsBird(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00005D00 File Offset: 0x00003F00
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x2B6BD10", Offset = "0x2B6A310", VA = "0x182B6BD10")]
		public static bool IsSmallBird(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00005D18 File Offset: 0x00003F18
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x2B6BD30", Offset = "0x2B6A330", VA = "0x182B6BD30")]
		public static bool IsLargeBird(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00005D30 File Offset: 0x00003F30
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x2B6BD50", Offset = "0x2B6A350", VA = "0x182B6BD50")]
		public static bool IsSmallWildlife(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00005D48 File Offset: 0x00003F48
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x2B6BD70", Offset = "0x2B6A370", VA = "0x182B6BD70")]
		public static bool IsLargeWildlife(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00005D60 File Offset: 0x00003F60
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x2B6BD90", Offset = "0x2B6A390", VA = "0x182B6BD90")]
		public static bool CanSwim(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00005D78 File Offset: 0x00003F78
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x2B6BDB0", Offset = "0x2B6A3B0", VA = "0x182B6BDB0")]
		public static bool IsCreepyPreyAnimal(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00005D90 File Offset: 0x00003F90
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x2B30940", Offset = "0x2B2EF40", VA = "0x182B30940")]
		public static bool IsEnemy(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00005DA8 File Offset: 0x00003FA8
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x2B6BDD0", Offset = "0x2B6A3D0", VA = "0x182B6BDD0")]
		public static bool IsRobbyOrPlayer(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00005DC0 File Offset: 0x00003FC0
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x2B6BDE0", Offset = "0x2B6A3E0", VA = "0x182B6BDE0")]
		public static Color GetColorForType(VailActorTypeId typeId)
		{
			return default(Color);
		}

		// Token: 0x040006F6 RID: 1782
		[Token(Token = "0x40006F6")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<VailActorTypeId, VailActorClassId> _typeToClass;
	}
}
