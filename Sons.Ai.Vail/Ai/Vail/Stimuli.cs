using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	public static class Stimuli
	{
		// Token: 0x06000655 RID: 1621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x2B38AD0", Offset = "0x2B370D0", VA = "0x182B38AD0")]
		private static void InitializeStimuliGrids()
		{
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x2B39CB0", Offset = "0x2B382B0", VA = "0x182B39CB0")]
		public static void Register(MonoBehaviourStimuli target)
		{
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x2B3A050", Offset = "0x2B38650", VA = "0x182B3A050")]
		public static void Unregister(MonoBehaviourStimuli target)
		{
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x2B3A280", Offset = "0x2B38880", VA = "0x182B3A280")]
		public static VailLevelGrid GetStimuliGrid(Stimuli.GridType gridType)
		{
			return null;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x2B3A320", Offset = "0x2B38920", VA = "0x182B3A320")]
		public static List<MonoBehaviourStimuli> GetStimuliInRadius(Vector3 position, float radius, List<Type> stimuliTypes)
		{
			return null;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x2B3AB00", Offset = "0x2B39100", VA = "0x182B3AB00")]
		private static void GetStimuliInRadius(ref List<MonoBehaviourStimuli> resultList, List<MonoBehaviourStimuli> stimuliList, Vector3 position, float radius)
		{
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x2B3AD00", Offset = "0x2B39300", VA = "0x182B3AD00")]
		public static List<MonoBehaviourStimuli> GetStimuliInWorld(List<Type> stimuliTypes)
		{
			return null;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00004F20 File Offset: 0x00003120
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x2B3B070", Offset = "0x2B39670", VA = "0x182B3B070")]
		public static int GetStimuliTypeCount(Type type)
		{
			return 0;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00004F38 File Offset: 0x00003138
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x2B3B1D0", Offset = "0x2B397D0", VA = "0x182B3B1D0")]
		public static bool IsGroup(Type type)
		{
			return default(bool);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600065E")]
		public static MonoBehaviourStimuli GetClosestStimuli<T>(Vector3 position, float maxRadius) where T : MonoBehaviourStimuli
		{
			return null;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x2B3B2A0", Offset = "0x2B398A0", VA = "0x182B3B2A0")]
		public static MonoBehaviourStimuli GetClosestStimuli(Vector3 position, float maxRadius, Type type)
		{
			return null;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x2B3B420", Offset = "0x2B39A20", VA = "0x182B3B420")]
		public static void UpdateGridIfNeeded()
		{
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x2B3B590", Offset = "0x2B39B90", VA = "0x182B3B590")]
		public static void MoveStaticStimuli(MonoBehaviourStimuli stimuli, Vector3 newPosition)
		{
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00004F50 File Offset: 0x00003150
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x2B3B7A0", Offset = "0x2B39DA0", VA = "0x182B3B7A0")]
		public static int GetCount()
		{
			return 0;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x2B3B9D0", Offset = "0x2B39FD0", VA = "0x182B3B9D0")]
		public static string GetId(Type type)
		{
			return null;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00004F68 File Offset: 0x00003168
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x2B3BBD0", Offset = "0x2B3A1D0", VA = "0x182B3BBD0")]
		public static bool Matches(Type type, string search)
		{
			return default(bool);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x2B3BF30", Offset = "0x2B3A530", VA = "0x182B3BF30")]
		private static void CacheStimuliTypeStrings()
		{
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x2B3C560", Offset = "0x2B3AB60", VA = "0x182B3C560")]
		public static ValueDropdownList<string> GetValueDropdownList(bool groupsOnly = false)
		{
			return null;
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x2B3C640", Offset = "0x2B3AC40", VA = "0x182B3C640")]
		public static ValueDropdownList<string> GetQueryValueDropdownList(Type targetType)
		{
			return null;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x2B3C8B0", Offset = "0x2B3AEB0", VA = "0x182B3C8B0")]
		private static List<Type> GetAllStimuliQueryTypes()
		{
			return null;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00004F80 File Offset: 0x00003180
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x2B3CE00", Offset = "0x2B3B400", VA = "0x182B3CE00")]
		private static bool IsValidWithTarget(Type queryType, Type targetType)
		{
			return default(bool);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x2B3D050", Offset = "0x2B3B650", VA = "0x182B3D050")]
		public static void OnNearbyStimuliGUI(Camera cam, float radius, string filter)
		{
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x2B3D250", Offset = "0x2B3B850", VA = "0x182B3D250")]
		private static void DrawStimuliFromGrid(VailLevelGrid grid, Camera cam, float radius, Color color, string filter)
		{
		}

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x0")]
		private static List<VailLevelGrid> _stimuliGrids;

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x8")]
		private static List<MonoBehaviourStimuli>[] _stimuliByType;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x10")]
		private static List<Type> _cachedStimuliQueryTypes;

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0x18")]
		private static ValueDropdownList<string> _cachedStimuliTypeNames;

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x20")]
		private static ValueDropdownList<string> _cachedStimuliGroupTypeNames;

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x28")]
		private static List<MonoBehaviourStimuli> _stimuliResultsList;

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Dictionary<Type, Stimuli.StimuliInfo> _stimuliTypeInfo;

		// Token: 0x0200009E RID: 158
		[Token(Token = "0x200009E")]
		private readonly struct StimuliInfo
		{
			// Token: 0x0600066D RID: 1645 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x2B3DDA0", Offset = "0x2B3C3A0", VA = "0x182B3DDA0")]
			public StimuliInfo(int gridId, int typeId, bool isGroup)
			{
			}

			// Token: 0x04000518 RID: 1304
			[Token(Token = "0x4000518")]
			[FieldOffset(Offset = "0x0")]
			public readonly int GridId;

			// Token: 0x04000519 RID: 1305
			[Token(Token = "0x4000519")]
			[FieldOffset(Offset = "0x4")]
			public readonly int TypeId;

			// Token: 0x0400051A RID: 1306
			[Token(Token = "0x400051A")]
			[FieldOffset(Offset = "0x8")]
			public readonly bool IsGroup;
		}

		// Token: 0x0200009F RID: 159
		[Token(Token = "0x200009F")]
		public enum GridType
		{
			// Token: 0x0400051C RID: 1308
			[Token(Token = "0x400051C")]
			WorldDynamic,
			// Token: 0x0400051D RID: 1309
			[Token(Token = "0x400051D")]
			Static,
			// Token: 0x0400051E RID: 1310
			[Token(Token = "0x400051E")]
			StaticTrees,
			// Token: 0x0400051F RID: 1311
			[Token(Token = "0x400051F")]
			StaticWater,
			// Token: 0x04000520 RID: 1312
			[Token(Token = "0x4000520")]
			StaticZone,
			// Token: 0x04000521 RID: 1313
			[Token(Token = "0x4000521")]
			StaticStructure,
			// Token: 0x04000522 RID: 1314
			[Token(Token = "0x4000522")]
			Audio,
			// Token: 0x04000523 RID: 1315
			[Token(Token = "0x4000523")]
			Character,
			// Token: 0x04000524 RID: 1316
			[Token(Token = "0x4000524")]
			Animal,
			// Token: 0x04000525 RID: 1317
			[Token(Token = "0x4000525")]
			Special
		}
	}
}
