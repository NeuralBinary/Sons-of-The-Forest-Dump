using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Gameplay.GPS
{
	// Token: 0x0200085B RID: 2139
	[Token(Token = "0x200085B")]
	[AddComponentMenu("Sons/Gameplay/GPS/GpsWorldActorLocators")]
	public class GpsWorldActorLocators : MonoBehaviour, IWorldActorLocators
	{
		// Token: 0x06003CFF RID: 15615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFF")]
		[Address(RVA = "0x35B4860", Offset = "0x35B2E60", VA = "0x1835B4860", Slot = "4")]
		public void AddGpsLocator(WorldSimActor actor, int iconId = -1)
		{
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D00")]
		[Address(RVA = "0x35B4AA0", Offset = "0x35B30A0", VA = "0x1835B4AA0", Slot = "5")]
		public void RemoveGpsLocator(WorldSimActor actor)
		{
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x00012960 File Offset: 0x00010B60
		[Token(Token = "0x6003D01")]
		[Address(RVA = "0x35B4C30", Offset = "0x35B3230", VA = "0x1835B4C30", Slot = "6")]
		public int GetActorLocatorTypeId(WorldSimActor actor)
		{
			return 0;
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D02")]
		[Address(RVA = "0x35B4CC0", Offset = "0x35B32C0", VA = "0x1835B4CC0")]
		public GpsWorldActorLocators()
		{
		}

		// Token: 0x04003394 RID: 13204
		[Token(Token = "0x4003394")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GPSLocator _gpsLocatorPrefab;

		// Token: 0x04003395 RID: 13205
		[Token(Token = "0x4003395")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<WorldSimActor, GPSLocator> _gpsLocators;
	}
}
