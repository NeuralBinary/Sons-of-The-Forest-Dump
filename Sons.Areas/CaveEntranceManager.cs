using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;

namespace Sons.Areas
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[AddComponentMenu("Sons/World/Cave Entrance Manager")]
	public class CaveEntranceManager : SingletonBehaviour<CaveEntranceManager>, IQuitHandler, IDisposable
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000003")]
		private static event Action<AreaMask, AreaMask, PlayerType> _onAreaMaskChanged
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2D27B40", Offset = "0x2D26140", VA = "0x182D27B40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x2D27CD0", Offset = "0x2D262D0", VA = "0x182D27CD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000004")]
		private static event Action<bool> _onDeepCavesChanged
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x2D27E60", Offset = "0x2D26460", VA = "0x182D27E60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x2D27FF0", Offset = "0x2D265F0", VA = "0x182D27FF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600002F RID: 47 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x17000001")]
		public static bool IsInCaves
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2D28180", Offset = "0x2D26780", VA = "0x182D28180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x17000002")]
		public static bool IsInDeepCaves
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x2D281C0", Offset = "0x2D267C0", VA = "0x182D281C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000031 RID: 49 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x17000003")]
		public static AreaMask CurrentAreaMask
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x2D28200", Offset = "0x2D26800", VA = "0x182D28200")]
			get
			{
				return AreaMask.None;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2D28240", Offset = "0x2D26840", VA = "0x182D28240", Slot = "11")]
		public void Dispose()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2D28470", Offset = "0x2D26A70", VA = "0x182D28470", Slot = "10")]
		public void OnQuit()
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2D28480", Offset = "0x2D26A80", VA = "0x182D28480", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2D284F0", Offset = "0x2D26AF0", VA = "0x182D284F0", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2D28540", Offset = "0x2D26B40", VA = "0x182D28540")]
		private void Update()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2D28550", Offset = "0x2D26B50", VA = "0x182D28550")]
		private static void UpdateAllPlayerAreaMask()
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2D286A0", Offset = "0x2D26CA0", VA = "0x182D286A0")]
		private static void OnUpdateMask(ref AreaMask oldMask, AreaMask newMask, PlayerType playerType)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2D28720", Offset = "0x2D26D20", VA = "0x182D28720")]
		private static void SetLocalPlayerCurrentArea(AreaMask areaMask)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2D287F0", Offset = "0x2D26DF0", VA = "0x182D287F0")]
		private static void OnCaveExit(AreaMask areaId)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2D28850", Offset = "0x2D26E50", VA = "0x182D28850")]
		private static void OnCaveEnter(AreaMask areaId)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2D288A0", Offset = "0x2D26EA0", VA = "0x182D288A0")]
		private static void OnDeepCaveEnter()
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2D28910", Offset = "0x2D26F10", VA = "0x182D28910")]
		private static void OnDeepCaveExit()
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2D28980", Offset = "0x2D26F80", VA = "0x182D28980")]
		private static void SetIsInDeepCaves(bool isInDeepCaves)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2D289F0", Offset = "0x2D26FF0", VA = "0x182D289F0")]
		public static CaveSystem GetCaveSystem(Vector3 location, bool checkTerrain)
		{
			return null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2D28C70", Offset = "0x2D27270", VA = "0x182D28C70")]
		public static CaveSystem GetCaveSystem(AreaMask areaMask)
		{
			return null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2D28D60", Offset = "0x2D27360", VA = "0x182D28D60")]
		public static void RegisterOnAreaMaskChanged(Action<AreaMask, AreaMask, PlayerType> action)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2D28DF0", Offset = "0x2D273F0", VA = "0x182D28DF0")]
		public static void UnregisterOnAreaMaskChanged(Action<AreaMask, AreaMask, PlayerType> action)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2D28E00", Offset = "0x2D27400", VA = "0x182D28E00")]
		public static void RegisterOnDeepCavesChanged(Action<bool> action)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2D28E60", Offset = "0x2D27460", VA = "0x182D28E60")]
		public static void UnregisterOnDeepCavesChanged(Action<bool> action)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2D28E70", Offset = "0x2D27470", VA = "0x182D28E70")]
		public static void RegisterCaveSystem(CaveSystem caveSystem)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2D294E0", Offset = "0x2D27AE0", VA = "0x182D294E0")]
		public static void UnregisterCaveSystem(CaveSystem caveSystem)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2D29B20", Offset = "0x2D28120", VA = "0x182D29B20")]
		public static void AddActiveCave(CaveSystem caveSystem)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2D29BE0", Offset = "0x2D281E0", VA = "0x182D29BE0")]
		private void AddActiveCaveInternal(CaveSystem caveSystem)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2D29C50", Offset = "0x2D28250", VA = "0x182D29C50")]
		public static void RemoveActiveCave(CaveSystem caveSystem)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2D29D10", Offset = "0x2D28310", VA = "0x182D29D10")]
		private void RemoveActiveCaveInternal(CaveSystem caveSystem)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2D29D90", Offset = "0x2D28390", VA = "0x182D29D90")]
		public CaveEntranceManager()
		{
		}

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x0")]
		private static List<CaveSystem> _caveSystems;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x8")]
		private static bool _isInCaves;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x9")]
		private static bool _isInDeepCaves;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x20")]
		private static AreaMask _currentAreaLocal;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x24")]
		private static AreaMask _currentAreaAllPlayers;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x28")]
		private List<CaveSystem> _activeCaveSystems;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x30")]
		private bool _isInCavesReadout;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x31")]
		private bool _disposed;
	}
}
