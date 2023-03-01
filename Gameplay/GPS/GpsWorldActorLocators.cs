using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Gameplay.GPS
{
	// Token: 0x0200070D RID: 1805
	[Token(Token = "0x200070D")]
	[AddComponentMenu("Sons/Gameplay/GPS/GpsWorldActorLocators")]
	public class GpsWorldActorLocators : MonoBehaviour, IWorldActorLocators
	{
		// Token: 0x06002F04 RID: 12036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F04")]
		[Address(RVA = "0x2E34750", Offset = "0x2E33750", VA = "0x182E34750", Slot = "4")]
		public void AddGpsLocator(WorldSimActor actor)
		{
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F05")]
		[Address(RVA = "0x2E348D0", Offset = "0x2E338D0", VA = "0x182E348D0", Slot = "5")]
		public void RemoveGpsLocator(WorldSimActor actor)
		{
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F06")]
		[Address(RVA = "0x2E34A30", Offset = "0x2E33A30", VA = "0x182E34A30")]
		public GpsWorldActorLocators()
		{
		}

		// Token: 0x040029AA RID: 10666
		[Token(Token = "0x40029AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GPSLocator _gpsLocatorPrefab;

		// Token: 0x040029AB RID: 10667
		[Token(Token = "0x40029AB")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<WorldSimActor, GPSLocator> _gpsLocators;
	}
}
