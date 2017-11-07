﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyectobubblesort;

namespace UnitTestBubblesort
{
    [TestClass]
    public class TestUnitario4
    {
        [TestMethod]
        public void TestMethod500()
        {
            //testeo con 500 elementos
            // arrange -  act  - assert
            Bubblesort bubble = new Bubblesort();
			int[] numbers = new int[] { 165, 226, 65, 434, 409, 205, 80, 493, 387, 285, 314, 14, 265, 16, 132, 326, 224, 193, 252, 183, 32, 124, 243, 361, 19, 96, 62, 297, 471, 371, 112, 337, 346, 98, 140, 476, 49, 160, 416, 431, 401, 88, 356, 105, 359, 345, 170, 333, 362, 358, 354, 411, 391, 57, 189, 187, 496, 327, 423, 312, 435, 267, 396, 270, 410, 497, 319, 433, 60, 76, 61, 148, 253, 84, 309, 436, 453, 35, 153, 51, 230, 174, 211, 56, 214, 308, 350, 498, 246, 489, 146, 209, 328, 255, 304, 175, 108, 50, 290, 322, 26, 412, 331, 245, 392, 397, 398, 121, 280, 311, 449, 320, 3, 222, 276, 446, 343, 36, 192, 315, 363, 6, 286, 185, 406, 216, 258, 313, 287, 295, 441, 39, 240, 277, 466, 282, 30, 171, 68, 196, 366, 281, 38, 437, 172, 264, 201, 305, 457, 495, 4, 210, 373, 318, 369, 235, 8, 100, 381, 349, 221, 419, 59, 479, 429, 317, 236, 154, 262, 136, 389, 259, 324, 74, 123, 106, 195, 186, 383, 425, 58, 52, 46, 101, 455, 69, 116, 268, 169, 87, 162, 227, 353, 42, 217, 388, 293, 325, 303, 384, 237, 488, 385, 5, 275, 135, 157, 47, 251, 427, 452, 395, 104, 469, 456, 115, 75, 413, 173, 271, 306, 247, 404, 86, 408, 266, 55, 472, 352, 289, 342, 461, 254, 159, 119, 299, 95, 145, 370, 93, 454, 260, 1, 2, 11, 301, 233, 360, 485, 483, 24, 399, 128, 91, 139, 137, 477, 298, 44, 94, 156, 334, 459, 415, 184, 487, 203, 279, 294, 491, 244, 7, 213, 380, 263, 53, 307, 249, 428, 292, 484, 475, 41, 463, 202, 390, 208, 77, 273, 134, 445, 215, 335, 129, 238, 176, 72, 85, 204, 28, 492, 300, 417, 348, 79, 444, 341, 18, 155, 20, 207, 494, 231, 144, 465, 330, 66, 481, 426, 474, 316, 234, 147, 283, 382, 22, 131, 198, 126, 117, 378, 256, 402, 336, 200, 25, 48, 355, 89, 163, 278, 206, 420, 167, 407, 473, 212, 83, 288, 470, 199, 344, 440, 464, 468, 141, 10, 133, 197, 82, 81, 31, 102, 71, 97, 152, 379, 367, 107, 54, 340, 386, 191, 478, 296, 448, 357, 92, 27, 149, 125, 248, 421, 168, 103, 480, 250, 78, 113, 138, 443, 180, 218, 40, 372, 376, 64, 400, 368, 182, 365, 219, 424, 109, 393, 177, 438, 181, 274, 442, 63, 164, 430, 114, 73, 232, 166, 45, 150, 194, 29, 394, 190, 34, 17, 239, 242, 178, 228, 12, 462, 405, 110, 161, 118, 67, 351, 143, 450, 451, 458, 70, 486, 323, 158, 339, 347, 422, 13, 9, 403, 90, 414, 460, 284, 439, 179, 499, 375, 261, 482, 321, 272, 15, 332, 418, 310, 329, 23, 364, 225, 490, 120, 37, 302, 127, 374, 291, 500, 447, 142, 33, 99, 241, 467, 269, 338, 257, 111, 188, 122, 377, 21, 432, 229, 223, 43, 220, 151, 130 };
            bubble.BubleSort(numbers);
            int[] valoreEsperado = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264, 265, 266, 267, 268, 269, 270, 271, 272, 273, 274, 275, 276, 277, 278, 279, 280, 281, 282, 283, 284, 285, 286, 287, 288, 289, 290, 291, 292, 293, 294, 295, 296, 297, 298, 299, 300, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326, 327, 328, 329, 330, 331, 332, 333, 334, 335, 336, 337, 338, 339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496, 497, 498, 499, 500 };
            CollectionAssert.AreEqual(valoreEsperado, numbers);

        }
    }
}
