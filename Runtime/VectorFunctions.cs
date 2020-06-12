﻿using Unity.Mathematics;
using UnityEngine;

namespace UME
{
    public static partial class UnityMathematicsExtensions
    {
        // Vector Specific Functions ------------------------------------------------------

        // Normalized
        public static float4 normalized(this float4 f) => math.normalize(f);
        public static float3 normalized(this float3 f) => math.normalize(f);
        public static float2 normalized(this float2 f) => math.normalize(f);
        
        public static float4 normalized(this Vector4 f) => math.normalize(f);
        public static float3 normalized(this Vector3 f) => math.normalize(f);
        public static float2 normalized(this Vector2 f) => math.normalize(f);
        
        public static double4 normalized(this double4 f) => math.normalize(f);
        public static double3 normalized(this double3 f) => math.normalize(f);
        public static double2 normalized(this double2 f) => math.normalize(f);
        
        // Normalized safely
        public static float4 normalizedsafe(this float4 f) => math.normalizesafe(f);
        public static float3 normalizedsafe(this float3 f) => math.normalizesafe(f);
        public static float2 normalizedsafe(this float2 f) => math.normalizesafe(f);
        
        public static float4 normalizedsafe(this Vector4 f) => math.normalizesafe(f);
        public static float3 normalizedsafe(this Vector3 f) => math.normalizesafe(f);
        public static float2 normalizedsafe(this Vector2 f) => math.normalizesafe(f);
        
        public static double4 normalizedsafe(this double4 f) => math.normalizesafe(f);
        public static double3 normalizedsafe(this double3 f) => math.normalizesafe(f);
        public static double2 normalizedsafe(this double2 f) => math.normalizesafe(f);

        
        //length
        public static float length(this float4 f) => math.length(f);
        public static float length(this float3 f) => math.length(f);
        public static float length(this float2 f) => math.length(f);
        
        public static float length(this Vector4 f) => math.length(f);
        public static float length(this Vector3 f) => math.length(f);
        public static float length(this Vector2 f) => math.length(f);
        
        public static double4 length(this double4 f) => math.length(f);
        public static double3 length(this double3 f) => math.length(f);
        public static double2 length(this double2 f) => math.length(f);


        //Length Squared
        public static float lengthsq(this float4 f) => math.lengthsq(f);
        public static float lengthsq(this float3 f) => math.lengthsq(f);
        public static float lengthsq(this float2 f) => math.lengthsq(f);
        
        public static float lengthsq(this Vector4 f) => math.lengthsq(f);
        public static float lengthsq(this Vector3 f) => math.lengthsq(f);
        public static float lengthsq(this Vector2 f) => math.lengthsq(f);
        
        public static double lengthsq(this double4 f) => math.lengthsq(f);
        public static double lengthsq(this double3 f) => math.lengthsq(f);
        public static double lengthsq(this double2 f) => math.lengthsq(f);

        // Square Root
        public static float4 sqrt(this float4 f) => math.sqrt(f);
        public static float3 sqrt(this float3 f) => math.sqrt(f);
        public static float2 sqrt(this float2 f) => math.sqrt(f);
        public static float sqrt(this float f) => math.sqrt(f);
        public static float sqrt(this int f) => math.sqrt(f);
        
        public static float4 sqrt(this Vector4 f) => math.sqrt(f);
        public static float3 sqrt(this Vector3 f) => math.sqrt(f);
        public static float2 sqrt(this Vector2 f) => math.sqrt(f);
        
        public static double4 sqrt(this double4 f) => math.sqrt(f);
        public static double3 sqrt(this double3 f) => math.sqrt(f);
        public static double2 sqrt(this double2 f) => math.sqrt(f);
        public static double sqrt(this double f) => math.sqrt(f);
        
        
        // Cube Root
        
        private const double dthird = 0.333333333333333333333;
        private const float fthird = 0.3333333333f;
            
        public static float4 cbrt(this float4 f) => f.sign() * f.abs().pow(fthird);
        public static float3 cbrt(this float3 f) => f.sign() * f.abs().pow(fthird);
        public static float2 cbrt(this float2 f) => f.sign() * f.abs().pow(fthird);
        public static float cbrt(this float f) => f.sign() * f.abs().pow(fthird);
        public static float cbrt(this int f) => f.sign() * f.abs().pow(fthird);
        
        public static float4 cbrt(this Vector4 f) => f.sign() * f.abs().pow(fthird);
        public static float3 cbrt(this Vector3 f) => f.sign() * f.abs().pow(fthird);
        public static float2 cbrt(this Vector2 f) => f.sign() * f.abs().pow(fthird);

        public static double4 cbrt(this double4 f) => f.sign() * f.abs().pow(dthird);
        public static double3 cbrt(this double3 f) => f.sign() * f.abs().pow(dthird);
        public static double2 cbrt(this double2 f) => f.sign() * f.abs().pow(dthird);
        public static double cbrt(this double f) => f.sign() * f.abs().pow(dthird);
        
        
        // Inverse cube root
        
        public static float4 rcbrt(this float4 f) => f.cbrt().rcp();
        public static float3 rcbrt(this float3 f) => f.cbrt().rcp();
        public static float2 rcbrt(this float2 f) => f.cbrt().rcp();
        public static float rcbrt(this float f) => f.cbrt().rcp();
        public static float rcbrt(this int f) => f.cbrt().rcp();
        
        public static float4 rcbrt(this Vector4 f) => f.cbrt().rcp();
        public static float3 rcbrt(this Vector3 f) => f.cbrt().rcp();
        public static float2 rcbrt(this Vector2 f) => f.cbrt().rcp();

        public static double4 rcbrt(this double4 f) => f.cbrt().rcp();
        public static double3 rcbrt(this double3 f) => f.cbrt().rcp();
        public static double2 rcbrt(this double2 f) => f.cbrt().rcp();
        public static double rcbrt(this double f) => f.cbrt().rcp();


        // Inverse Square Root
        
        public static float4 rsqrt(this float4 f) => math.rsqrt(f);
        public static float3 rsqrt(this float3 f) => math.rsqrt(f);
        public static float2 rsqrt(this float2 f) => math.rsqrt(f);
        public static float rsqrt(this float f) => math.rsqrt(f);
        public static float rsqrt(this int f) => math.rsqrt(f);
        
        public static float4 rsqrt(this Vector4 f) => math.rsqrt(f);
        public static float3 rsqrt(this Vector3 f) => math.rsqrt(f);
        public static float2 rsqrt(this Vector2 f) => math.rsqrt(f);
        
        public static double4 rsqrt(this double4 f) => math.rsqrt(f);
        public static double3 rsqrt(this double3 f) => math.rsqrt(f);
        public static double2 rsqrt(this double2 f) => math.rsqrt(f);
        public static double rsqrt(this double f) => math.rsqrt(f);


        //Math Operations From Matrices -------------------------------------------------
        
        //Self Distance
        public static float distance(this float2x2 f) => math.distance(f.c0, f.c1);
        public static float distance(this float3x2 f) => math.distance(f.c0, f.c1);
        public static float distance(this float4x2 f) => math.distance(f.c0, f.c1);
        
        public static double distance(this double4x2 f) => math.distance(f.c0, f.c1);
        public static double distance(this double3x2 f) => math.distance(f.c0, f.c1);
        public static double distance(this double2x2 f) => math.distance(f.c0, f.c1);
        
        // Self Squared Distance
        public static float distancesq(this float2x2 f) => math.distancesq(f.c0, f.c1);
        public static float distancesq(this float3x2 f) => math.distancesq(f.c0, f.c1);
        public static float distancesq(this float4x2 f) => math.distancesq(f.c0, f.c1);
        
        public static double distancesq(this double4x2 f) => math.distancesq(f.c0, f.c1);
        public static double distancesq(this double3x2 f) => math.distancesq(f.c0, f.c1);
        public static double distancesq(this double2x2 f) => math.distancesq(f.c0, f.c1);
        
        // Self Cross
        public static float3 cross(this float3x2 f) => math.cross(f.c0, f.c1);
        public static double3 cross(this double3x2 f) => math.cross(f.c0, f.c1);
        
        // Self Dot
        public static float dot(this float4x2 f) => math.dot(f.c0, f.c1);
        public static float dot(this float3x2 f) => math.dot(f.c0, f.c1);
        public static float dot(this float2x2 f) => math.dot(f.c0, f.c1);
        
        public static double dot(this double4x2 f) => math.dot(f.c0, f.c1);
        public static double dot(this double3x2 f) => math.dot(f.c0, f.c1);
        public static double dot(this double2x2 f) => math.dot(f.c0, f.c1);
        
        
        // Reflect -------------------------------------------------------------
        
        /// Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0f * dot(i, n) * n
        public static float4 reflect(this float4 f, float4 n) => math.reflect(f, n);
        /// <inheritdoc cref="reflect(float4,float4)"/>
        public static float3 reflect(this float3 f, float3 n) => math.reflect(f, n);
        /// <inheritdoc cref="reflect(float4,float4)"/>
        public static float2 reflect(this float2 f, float2 n) => math.reflect(f, n);

        /// <inheritdoc cref="reflect(float4,float4)"/>
        public static float4 reflect(this Vector4 f, float4 n) => math.reflect(f, n);
        /// <inheritdoc cref="reflect(float4,float4)"/>
        public static float3 reflect(this Vector3 f, float3 n) => math.reflect(f, n);
        /// <inheritdoc cref="reflect(float4,float4)"/>
        public static float2 reflect(this Vector2 f, float2 n) => math.reflect(f, n);
        
        /// <inheritdoc cref="reflect(float4,float4)"/>
        public static double4 reflect(this double4 f, double4 n) => math.reflect(f, n);
        /// <inheritdoc cref="reflect(float4,float4)"/>
        public static double3 reflect(this double3 f, double3 n) => math.reflect(f, n);
        /// <inheritdoc cref="reflect(float4,float4)"/>
        public static double2 reflect(this double2 f, double2 n) => math.reflect(f, n);
        
        // TODO: Refract
    }
}