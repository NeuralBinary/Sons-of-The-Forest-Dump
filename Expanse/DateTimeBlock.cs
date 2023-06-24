using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[ExecuteInEditMode]
	[Serializable]
	public class DateTimeBlock : MonoBehaviour
	{
		// Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000205")]
		[Address(RVA = "0xAB82A0", Offset = "0xAB68A0", VA = "0x180AB82A0")]
		private void Update()
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000206")]
		[Address(RVA = "0xAB89C0", Offset = "0xAB6FC0", VA = "0x180AB89C0")]
		public void SetDateTimeLocal(DateTime dateTime)
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000207")]
		[Address(RVA = "0xAB89E0", Offset = "0xAB6FE0", VA = "0x180AB89E0")]
		public void SetDateTimeUTC(DateTime dateTime)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00004D9C File Offset: 0x00002F9C
		[Token(Token = "0x6000208")]
		[Address(RVA = "0xAB8AE0", Offset = "0xAB70E0", VA = "0x180AB8AE0")]
		private static double daysSinceEpoch(DateTime dateTime)
		{
			return 0.0;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000209")]
		[Address(RVA = "0xAB8B80", Offset = "0xAB7180", VA = "0x180AB8B80")]
		public void CalculateSunPositionEnv(float internalHour, float d, float ecl, out double outAzimuth, out double outAltitude)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020A")]
		[Address(RVA = "0xAB8F00", Offset = "0xAB7500", VA = "0x180AB8F00")]
		public void CalculateMoonPositionEnv(float d, float ecl, out double outAzimuth, out double outAltitude)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020B")]
		[Address(RVA = "0xAB9300", Offset = "0xAB7900", VA = "0x180AB9300")]
		public DateTimeBlock()
		{
		}

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Celestial Body that will have the position of the sun.")]
		public CelestialBodyBlock m_sun;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Celestial Body that will have the position of the moon.")]
		public CelestialBodyBlock m_moon;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Night sky block that this controls.")]
		public NightSkyBlock m_nightSky;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Rotation speed of night sky along each axis.")]
		public Vector3 m_nightSkyRotationSpeed;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Latitude coordinate of the player.")]
		[Range(-90f, 90f)]
		public float m_latitude;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x48")]
		[Range(-180f, 180f)]
		[Tooltip("Longitude coordinate of the player.")]
		public float m_longitude;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Local time---so UTC time, with the UTC offset applied.")]
		public SunTime m_timeLocal;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x58")]
		public float m_skyOffset;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x5C")]
		[Tooltip("Offset to UTC---useful for being able to specify time in local time where your latitude/longitude coordinates are. Specify as the number of hours ahead your location is. In Munich, 12:00 local time is 10:00 UTC, so you would set this parameter to 2.")]
		[Range(-13f, 13f)]
		public int m_timeUTCOffset;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		private const double Deg2Rad = 0.017453292519943295;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		private const double Rad2Deg = 57.29577951308232;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x60")]
		private float LST;
	}
}
