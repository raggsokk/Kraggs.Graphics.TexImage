///////////////////////////////////////////////////////////////////////////////////
/// OpenGL Image (gli.g-truc.net)
///
/// Copyright (c) 2008 - 2012 G-Truc Creation (www.g-truc.net)
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
/// 
/// The above copyright notice and this permission notice shall be included in
/// all copies or substantial portions of the Software.
/// 
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
/// THE SOFTWARE.
///
/// @ref core
/// @file gli/core/format.hpp
/// @date 2012-10-16 / 2012-10-16
/// @author Christophe Riccio
///////////////////////////////////////////////////////////////////////////////////

using System;

namespace Kraggs.Graphics.TexImage
{
    /// <summary>
    /// OpenGL External Format.
    /// </summary>
    public enum GLIExternalFormat
    {
        EXTERNAL_NONE = 0,
        EXTERNAL_RED = 6403,
        EXTERNAL_RG = 33319,

        EXTERNAL_RGB = 6407,
        EXTERNAL_RGBA = 6408,

        EXTERNAL_BGR = 32992,
        EXTERNAL_BGRA = 32993,

        EXTERNAL_STENCIL = 6401,
        EXTERNAL_DEPTH = 6402,
        EXTERNAL_DEPTH_STENCIL = 34041,

        EXTERNAL_RED_INTEGER = 36244,
        EXTERNAL_RG_INTEGER = 33320,

        EXTERNAL_RGB_INTEGER = 36248,
        EXTERNAL_RGBA_INTEGER = 36249,

        EXTERNAL_BGR_INTEGER = 36250,
        EXTERNAL_BGRA_INTEGER = 36251,



        EXTERNAL_RGB_DXT1 = 0x83F0,					//GL_COMPRESSED_RGB_S3TC_DXT1_EXT
        EXTERNAL_RGBA_DXT1 = 0x83F1,				//GL_COMPRESSED_RGBA_S3TC_DXT1_EXT
        EXTERNAL_RGBA_DXT3 = 0x83F2,				//GL_COMPRESSED_RGBA_S3TC_DXT3_EXT
        EXTERNAL_RGBA_DXT5 = 0x83F3,				//GL_COMPRESSED_RGBA_S3TC_DXT5_EXT
        EXTERNAL_R_ATI1N_UNORM = 0x8DBB,			//GL_COMPRESSED_RED_RGTC1
        EXTERNAL_R_ATI1N_SNORM = 0x8DBC,			//GL_COMPRESSED_SIGNED_RED_RGTC1
        EXTERNAL_RG_ATI2N_UNORM = 0x8DBD,			//GL_COMPRESSED_RG_RGTC2
        EXTERNAL_RG_ATI2N_SNORM = 0x8DBE,			//GL_COMPRESSED_SIGNED_RG_RGTC2
        EXTERNAL_RGB_BP_UNSIGNED_FLOAT = 0x8E8F,	//GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT
        EXTERNAL_RGB_BP_SIGNED_FLOAT = 0x8E8E,		//GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT
        EXTERNAL_RGB_BP_UNORM = 0x8E8C,				//GL_COMPRESSED_RGBA_BPTC_UNORM

        EXTERNAL_RGB_PVRTC_4BPPV1 = 0x8C00,				//GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG
        EXTERNAL_RGB_PVRTC_2BPPV1 = 0x8C01,				//GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG
        EXTERNAL_RGBA_PVRTC_4BPPV1 = 0x8C02,			//GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG
        EXTERNAL_RGBA_PVRTC_2BPPV1 = 0x8C03,			//GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG
        EXTERNAL_ATC_RGB = 0x8C92,						//GL_ATC_RGB_AMD
        EXTERNAL_ATC_RGBA_EXPLICIT_ALPHA = 0x8C93,		//GL_ATC_RGBA_EXPLICIT_ALPHA_AMD
        EXTERNAL_ATC_RGBA_INTERPOLATED_ALPHA = 0x87EE,	//GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD

        EXTERNAL_RGBA_ASTC_4x4 = 0x93B0,				//GL_COMPRESSED_RGBA_ASTC_4x4_KHR
        EXTERNAL_RGBA_ASTC_5x4 = 0x93B1,				//GL_COMPRESSED_RGBA_ASTC_5x4_KHR
        EXTERNAL_RGBA_ASTC_5x5 = 0x93B2,				//GL_COMPRESSED_RGBA_ASTC_5x5_KHR
        EXTERNAL_RGBA_ASTC_6x5 = 0x93B3,				//GL_COMPRESSED_RGBA_ASTC_6x5_KHR
        EXTERNAL_RGBA_ASTC_6x6 = 0x93B4,				//GL_COMPRESSED_RGBA_ASTC_6x6_KHR
        EXTERNAL_RGBA_ASTC_8x5 = 0x93B5,				//GL_COMPRESSED_RGBA_ASTC_8x5_KHR
        EXTERNAL_RGBA_ASTC_8x6 = 0x93B6,				//GL_COMPRESSED_RGBA_ASTC_8x6_KHR
        EXTERNAL_RGBA_ASTC_8x8 = 0x93B7,				//GL_COMPRESSED_RGBA_ASTC_8x8_KHR
        EXTERNAL_RGBA_ASTC_10x5 = 0x93B8,				//GL_COMPRESSED_RGBA_ASTC_10x5_KHR
        EXTERNAL_RGBA_ASTC_10x6 = 0x93B9,				//GL_COMPRESSED_RGBA_ASTC_10x6_KHR
        EXTERNAL_RGBA_ASTC_10x8 = 0x93BA,				//GL_COMPRESSED_RGBA_ASTC_10x8_KHR
        EXTERNAL_RGBA_ASTC_10x10 = 0x93BB,				//GL_COMPRESSED_RGBA_ASTC_10x10_KHR
        EXTERNAL_RGBA_ASTC_12x10 = 0x93BC,				//GL_COMPRESSED_RGBA_ASTC_12x10_KHR
        EXTERNAL_RGBA_ASTC_12x12 = 0x93BD				//GL_COMPRESSED_RGBA_ASTC_12x12_KHR

    }
}
